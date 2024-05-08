
namespace BlazorEcommerce.Server.Services.ProductServices
{
    public class ProductService : IProductService
	{
		private readonly DataContext _context;

		public ProductService(DataContext context)
        {
			_context = context;
		}

		public async Task<ServiceResponse<Product>> GetProductByIdAsync(int Id)
		{
			var response = new ServiceResponse<Product>();
			var product = await _context.Products
				.Include(p => p.Variants)
				.ThenInclude(v => v.ProductType)
				.FirstOrDefaultAsync(p => p.Id == Id);
            if (product == null)
            {
				response.Success = false;
				response.Message = "Sorry, but this product is not exist";
            }
			else
			{
				response.Data = product;
			}

			return response;
        }

		public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
		{
			var response = new ServiceResponse<List<Product>> 
			{
				Data = await _context.Products.Include(p => p.Variants).ToListAsync()
			};

			return response;
		}

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
        {
			var response = new ServiceResponse<List<Product>>
			{
				Data = await _context.Products
							.Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
							.Include(p => p.Variants)
							.ToListAsync()
			};

			return response;
        }

        public async Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText)
        {
            var products = await FindProductBySearchText(searchText);

			List<string> result = new List<string>();

			foreach (var product in products)
			{
				if (product.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
				{
					result.Add(product.Title);
				}

				if(product.Description != null)
				{
					var punctuation = product.Description.Where(char.IsPunctuation)
						.Distinct().ToArray();
					var words = product.Description.Split()
						.Select(s => s.Trim(punctuation));

					foreach (var word in words)
					{
						if(word.Contains(searchText, StringComparison.OrdinalIgnoreCase)
							&& !result.Contains(word))
						{
							result.Add(word);
						}
					}
				}
			}

			return new ServiceResponse<List<string>> { Data = result };
        }

        public async Task<ServiceResponse<List<Product>>> SearchProducts(string searchText)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await FindProductBySearchText(searchText)
            };

            return response;
        }

        private async Task<List<Product>> FindProductBySearchText(string searchText)
        {
            return await _context.Products
                                .Where(p =>
                                    p.Title.ToLower().Equals(searchText.ToLower())
                                    ||
                                    p.Description.ToLower().Contains(searchText.ToLower()))
                                .Include(p => p.Variants)
                                .ToListAsync();
        }
    }
}

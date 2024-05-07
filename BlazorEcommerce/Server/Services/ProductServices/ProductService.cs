﻿
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
			var product = await _context.Products.FindAsync(Id);
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
				Data = await _context.Products.ToListAsync()
			};

			return response;
		}

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
        {
			var response = new ServiceResponse<List<Product>>
			{
				Data = await _context.Products
							.Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower())).ToListAsync()
			};

			return response;
        }
    }
}

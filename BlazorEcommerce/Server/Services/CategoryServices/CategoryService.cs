
namespace BlazorEcommerce.Server.Services.CategoryServices
{
	public class CategoryService : ICategoryService
	{
		private readonly DataContext _context;

		public CategoryService(DataContext context)
        {
			_context = context;
		}

        public async Task<ServiceResponse<List<Category>>> GetAllCategoriesAsync()
		{
			var categories = await _context.Categories.ToListAsync();
			return new ServiceResponse<List<Category>> 
			{ 
				Data = categories 
			};
		}
	}
}

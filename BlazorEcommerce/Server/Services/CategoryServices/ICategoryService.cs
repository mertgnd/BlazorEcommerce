namespace BlazorEcommerce.Server.Services.CategoryServices
{
	public interface ICategoryService
	{
		Task<ServiceResponse<List<Category>>> GetAllCategoriesAsync();
	}
}

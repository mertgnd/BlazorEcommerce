namespace BlazorEcommerce.Client.Services.CategoryServices
{
	public interface ICategoryService
	{
        List<Category> Categories { get; set; }
		Task GetCategories();
    }
}

namespace BlazorEcommerce.Client.Services.ProductServices
{
	public interface IProductService
	{
		event Action ProductsChanged;
		List<Product> Products { get; set; }
		string Message { get; set; }
		int CurrentPage { get; set; }
		int PageCount { get; set; }
		string LastSearchText { get; set; }
		// If we will make a call then products will come according to their category.
		Task GetProducts(string? categoryUrl = null);
		Task<ServiceResponse<Product>> GetProductById(int productId);
		Task SearchProducts(string searchText, int page);
		Task<List<string>> GetProductSearchSuggestions(string searchText);
	}
}
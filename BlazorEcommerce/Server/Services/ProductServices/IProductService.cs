namespace BlazorEcommerce.Server.Services.ProductServices
{
	public interface IProductService
	{
		Task<ServiceResponse<List<Product>>> GetProductsAsync();
		Task<ServiceResponse<Product>> GetProductByIdAsync(int Id);
        Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl);
		Task<ServiceResponse<List<Product>>> SearchProducts(string searchText);
		Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);
    }
}

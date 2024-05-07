namespace BlazorEcommerce.Client.Services.ProductServices
{
	public interface IProductService
	{
		List<Product> Products { get; set; }
		Task GetProducts();
	}
}

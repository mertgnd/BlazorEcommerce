﻿
namespace BlazorEcommerce.Client.Services.ProductServices
{
	public class ProductService : IProductService
	{
		private readonly HttpClient _httpClient;

		public ProductService(HttpClient httpClient)
        {
			_httpClient = httpClient;
		}

        public List<Product> Products { get; set; } = new List<Product>();
		public string Message { get; set; } = "Loading Product";
		public int CurrentPage { get; set; } = 1;
		public int PageCount { get; set; } = 0;
		public string LastSearchText { get; set; } = string.Empty;

		public event Action ProductsChanged;

        public async Task<ServiceResponse<Product>> GetProductById(int productId)
		{
			var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
			return result;
		}

		public async Task GetProducts(string? categoryUrl = null)
		{
			var result = categoryUrl == null ? await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product/featured") :
											   await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
			if(result != null && result.Data  != null)
			{
				Products = result.Data;
			}

			CurrentPage = 1;
			PageCount = 0;

			if (Products.Count == 0) Message = "No Product Found.";

			ProductsChanged.Invoke();
		}

        public async Task<List<string>> GetProductSearchSuggestions(string searchText)
        {
			var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<string>>>($"api/product/searchsuggestions/{searchText}");
			return result.Data;
        }

		public Task<List<string>> GetProductSearchSuggestions(string searchText, int Page)
		{
			throw new NotImplementedException();
		}

		public async Task SearchProducts(string searchText, int page)
        {
			LastSearchText = searchText;
			var result = await _httpClient.GetFromJsonAsync<ServiceResponse<ProductSearchResultDto>>($"api/product/search/{searchText}/{page}");
			
			if(result != null && result.Data!= null)
			{
				Products = result.Data.Products;
				CurrentPage = result.Data.CurrentPage;
				PageCount = result.Data.Pages;
			}

			if (Products.Count == 0) Message = "No Product Found";
			ProductsChanged?.Invoke();
        }
    }
}

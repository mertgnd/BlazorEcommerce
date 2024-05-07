﻿
namespace BlazorEcommerce.Client.Services.CategoryServices
{
	public class CategoryService : ICategoryService
	{
		private readonly HttpClient _httpClient;

		public CategoryService(HttpClient httpClient)
        {
			_httpClient = httpClient;
		}

        public List<Category> Categories { get; set; } = new List<Category>();

		public async Task GetCategories()
		{
			var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
			if (response != null && response.Data != null)
			{
				Categories = response.Data;
			}
		}
	}
}

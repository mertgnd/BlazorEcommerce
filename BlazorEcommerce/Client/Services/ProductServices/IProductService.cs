﻿namespace BlazorEcommerce.Client.Services.ProductServices
{
	public interface IProductService
	{
		event Action ProductsChanged;
		List<Product> Products { get; set; }
		// If we will make a call then products will come according to their category.
		Task GetProducts(string? categoryUrl = null);
		Task<ServiceResponse<Product>> GetProductById(int productId);
	}
}

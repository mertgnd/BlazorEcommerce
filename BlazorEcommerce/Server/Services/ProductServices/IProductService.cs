﻿namespace BlazorEcommerce.Server.Services.ProductServices
{
	public interface IProductService
	{
		Task<ServiceResponse<List<Product>>> GetProductsAsync();
	}
}

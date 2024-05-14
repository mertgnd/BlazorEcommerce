namespace BlazorEcommerce.Server.Services.CartServices
{
	public interface ICartService
	{
		Task<ServiceResponse<List<CartProductResponse>>> GetCartProducts(List<CartItem> cartItems);
	}
}

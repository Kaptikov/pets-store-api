using pets_store_api.Models;

namespace pets_store_api.Services.CartService
{
    public interface ICartService
    {
        Task<List<Cart>> GetAllCart();
        Task<Cart>? GetSingleCart(int id);

        //Task<List<Cart>> AddCart(Cart cart);

        //Task<List<Cart>?> UpdateCart(int id, Cart request);

        //Task<List<Cart>?> DeteleCart(int id);
    }
}

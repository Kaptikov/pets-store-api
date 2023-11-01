using Microsoft.EntityFrameworkCore;
using pets_store_api.Data;
using pets_store_api.Models;

namespace pets_store_api.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly DataContext _context;

        public CartService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Cart>> GetAllCart()
        {
            var carts = await _context.Carts.ToListAsync();
            return carts;
        }

        public async Task<Cart?> GetSingleCart(int id)
        {
            var cart = await _context.Carts.FindAsync(id);
            if (cart is null)
                return cart;

            return cart;
        }
    }
}

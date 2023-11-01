using Microsoft.EntityFrameworkCore;
using pets_store_api.Data;
using pets_store_api.Models;

namespace pets_store_api.Services.CartItemService
{
    public class CartItemService : ICartItemService
    {
        private readonly DataContext _context;

        public CartItemService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<CartItem>> AddCartItem(CartItem cartItem)
        {
            _context.CartItems.Add(cartItem);
            await _context.SaveChangesAsync();

            return await _context.CartItems.ToListAsync();
        }

        public async Task<List<CartItem>?> DeteleCartItem(int id)
        {
            var cartItem = await _context.CartItems.FindAsync(id);
            if (cartItem is null)
                return null;

            _context.CartItems.Remove(cartItem);
            await _context.SaveChangesAsync();
            return await _context.CartItems.ToListAsync();
        }

        public async Task<List<CartItem>> GetAllCartItem()
        {
            var cartItems = await _context.CartItems.ToListAsync();
            return cartItems;
        }

        public async Task<CartItem?> GetSingleCartItem(int id)
        {
            var cartItem = await _context.CartItems.FindAsync(id);
            if (cartItem is null)
                return cartItem;

            return cartItem;
        }

        public async Task<List<CartItem>?> UpdateCartItem(int id, CartItem request)
        {
            var cartItem = await _context.CartItems.FindAsync(id);
            if (cartItem is null)
                return null;

            //cartItem.Name = request.Name;
            //cartItem.Email = request.Email;
            //cartItem.PhoneNumber = request.PhoneNumber;
            cartItem.Quantity = request.Quantity;


            await _context.SaveChangesAsync();

            return await _context.CartItems.ToListAsync();
        }
    }
}

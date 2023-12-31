﻿using pets_store_api.Models;

namespace pets_store_api.Services.CartItemService
{
    public interface ICartItemService
    {
        Task<List<CartItem>> GetAllCartItem();
        Task<CartItem>? GetSingleCartItem(int id);

        Task<List<CartItem>> AddCartItem(CartItem cartItem);

        Task<List<CartItem>?> UpdateCartItem(int id, CartItem request);

        Task<List<CartItem>?> DeteleCartItem(int id);
    }
}

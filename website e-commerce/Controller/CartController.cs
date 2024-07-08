﻿using Microsoft.AspNetCore.Mvc;
using website_e_commerce.Models;
using website_e_commerce.Services;

using System.Collections.Generic;
using System.Threading.Tasks;
namespace website_e_commerce.Controller
{
    public class CartController : BaseController
    {
        private readonly CartService _cartService;

        public CartController(CartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("{userId}")]
        public async Task<IEnumerable<CartItem>> GetCartItems(int userId)
        {
            return await _cartService.GetCartItemsByUserIdAsync(userId);
        }

        [HttpPost]
        public async Task<CartItem> AddCartItem([FromBody] CartItem cartItem)
        {
            return await _cartService.CreateAsync(cartItem);
        }

        [HttpPut("{id}")]
        public async Task<CartItem> UpdateCartItem(int id, [FromBody] CartItem cartItem)
        {
            cartItem.Id = id;
            return await _cartService.UpdateAsync(cartItem);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCartItem(int id)
        {
            await _cartService.DeleteAsync(id);
            return NoContent();
        }
    }
}

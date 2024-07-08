﻿using website_e_commerce.Data;
using website_e_commerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using website_e_commerce.Base;
namespace website_e_commerce.Services
{
    public class OrderService : BaseService<Order>
    {
        public OrderService(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Order> CreateOrderAsync(Order order)
        {
            order.Status = "Created";
            return await CreateAsync(order);
        }

        public async Task<Order> UpdateOrderStatusAsync(int id, string status)
        {
            var order = await GetByIdAsync(id);
            if (order != null)
            {
                order.Status = status;
                await UpdateAsync(order);
            }
            return order;
        }
    }
}
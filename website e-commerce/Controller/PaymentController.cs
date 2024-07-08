﻿using Microsoft.AspNetCore.Mvc;
using website_e_commerce.Models;
using website_e_commerce.Services;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace website_e_commerce.Controller
{
    public class PaymentController : BaseController
    {
        private readonly PaymentService _paymentService;

        public PaymentController(PaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        public async Task<IEnumerable<Payment>> GetAll()
        {
            return await _paymentService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Payment> GetById(int id)
        {
            return await _paymentService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<Payment> Create([FromBody] Payment payment)
        {
            return await _paymentService.CreateAsync(payment);
        }

        [HttpPut("{id}")]
        public async Task<Payment> Update(int id, [FromBody] Payment payment)
        {
            payment.Id = id;
            return await _paymentService.UpdateAsync(payment);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _paymentService.DeleteAsync(id);
            return NoContent();
        }

        [HttpPost("process")]
        public async Task<Payment> ProcessPayment([FromBody] Payment payment)
        {
            return await _paymentService.ProcessPaymentAsync(payment);
        }
    }
}
using CargoManager.Core.Entities;
using CargoManager.Infrastructure.Data;
using CargoManager.Infrastructure.Repositories.Genric;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Infrastructure.Repositories.RazorPay
{
    public class PaymentRepository 
    {
        private readonly AppDbContext _context;

        public PaymentRepository(AppDbContext context) 
        {
            _context = context;
        }

        //public async Task<Payment?> GetByOrderIdAsync(string orderId)
        //{
        //    return await _context.Payments.FirstOrDefaultAsync(p => p.RazorpayOrderId == orderId);
        //}

        //public async Task UpdateAsync(Payment entity)
        //{
        //    _context.Payments.Update(entity); // Use the Payments DbSet directly
        //    await _context.SaveChangesAsync();
        //}

    }
}

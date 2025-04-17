using CargoManager.Core.Entities;
using CargoManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Infrastructure.Repositories.RazorPay
{
    public interface IPaymentRepository : IGenericRepository<Payment>
    {
        Task<Payment?> GetByOrderIdAsync(string razorpayOrderId);

       // Task UpdateAsync(Payment entity);
    }
}

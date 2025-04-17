using CargoManager.Application.DTO_s.PayDTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Interfaces
{
    public interface IPaymentService
    {
        Task<string> CreatePaymentAsync(CreatePaymentDto dto);
        Task<bool> VerifyPaymentAsync(VerifyPaymentDto dto);
    }
}

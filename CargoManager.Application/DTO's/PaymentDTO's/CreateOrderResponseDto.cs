using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.DTO_s.PaymentDTO_s
{
    public class CreateOrderResponseDto
    {
        public string OrderId { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
    }
}

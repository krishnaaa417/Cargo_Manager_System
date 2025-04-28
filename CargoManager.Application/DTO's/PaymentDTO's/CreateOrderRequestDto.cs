using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.DTO_s.PaymentDTO_s
{
    public class CreateOrderRequestDto
    {
        public decimal Amount { get; set; } // In INR paisa, so ₹10 = 1000
        public string Currency { get; set; } = "INR";
        public string Receipt { get; set; }
    }
}

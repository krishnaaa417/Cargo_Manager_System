using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.DTO_s.PayDTO_s
{
    public class PaymentDto
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

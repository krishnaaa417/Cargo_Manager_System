using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Core.Entities
{
    public class PaymentOrder
    {
        public int Id { get; set; }
        public string RazorpayOrderId { get; set; }
        public int Amount { get; set; }
        public string Currency { get; set; }
        public string Receipt { get; set; }
        public string Status { get; set; } // created, paid, failed, etc.
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Optional: Link to Customer or Cargo
        public int? CargoId { get; set; }
        public Cargo Cargo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Core
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }

        // Foreign Keys
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int? EmployeeId { get; set; } // Optional
        public Employee Employee { get; set; }

        // Navigation
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public Payment Payment { get; set; }
    }
}

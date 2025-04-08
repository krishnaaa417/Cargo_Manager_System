using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Core
{
    public  class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactInfo { get; set; }

        // Navigation: One Customer → Many Orders
        public ICollection<Order> Orders { get; set; }
    }
}

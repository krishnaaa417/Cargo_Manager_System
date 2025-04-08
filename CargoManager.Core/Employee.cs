using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Core
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        // If you want to assign order delivery to employees in future
        public ICollection<Order> OrdersHandled { get; set; }
    }
}

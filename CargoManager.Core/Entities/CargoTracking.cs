using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Core.Entities
{
    public class CargoTracking
    {
        public int Id { get; set; }
        public int CargoId { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime UpdatedAt { get; set; }

        public Cargo Cargo { get; set; }
    }
}

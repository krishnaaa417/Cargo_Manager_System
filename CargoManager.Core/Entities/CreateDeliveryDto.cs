using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Core.Entities
{
    public class CreateDeliveryDto
    {
        public int CargoId { get; set; }
        public string DeliveryStatus { get; set; } = string.Empty;
        public DateTime EstimatedDeliveryDate { get; set; }
        public string? Remarks { get; set; }
    }
}

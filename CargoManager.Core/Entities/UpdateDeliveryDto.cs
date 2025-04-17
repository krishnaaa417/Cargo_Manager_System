using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Core.Entities
{
    public class UpdateDeliveryDto
    {
        public int Id { get; set; }
        public string DeliveryStatus { get; set; } = string.Empty;
        public DateTime? DeliveredDate { get; set; }
        public string? Remarks { get; set; }
    }
}

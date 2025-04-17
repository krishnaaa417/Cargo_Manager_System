using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Core.Entities
{
    public class Delivery
    {
        public int Id { get; set; }

        [Required]
        public int CargoId { get; set; }

        [Required]
        public string DeliveryStatus { get; set; } = string.Empty;

        [Required]
        public DateTime EstimatedDeliveryDate { get; set; }

        public DateTime? DeliveredDate { get; set; }

        public string? Remarks { get; set; }

        // Navigation (optional)
        public Cargo? Cargo { get; set; }
    }
}

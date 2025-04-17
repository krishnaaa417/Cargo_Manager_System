using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.DTO_s.CargoTrackingDtos
{
    public class CargoTrackingDto
    {
        public int Id { get; set; }
        public int CargoId { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

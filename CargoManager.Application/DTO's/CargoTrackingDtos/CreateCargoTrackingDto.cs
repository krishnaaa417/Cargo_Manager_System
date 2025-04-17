using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.DTO_s.CargoTrackingDtos
{
    public class CreateCargoTrackingDto
    {
        public int CargoId { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
    }
}

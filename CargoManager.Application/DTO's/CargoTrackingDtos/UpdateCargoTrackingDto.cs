using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.DTO_s.CargoTrackingDtos
{
    public class UpdateCargoTrackingDto
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
    }
}

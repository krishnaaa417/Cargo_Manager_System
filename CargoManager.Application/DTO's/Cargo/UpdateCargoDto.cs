using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.DTO_s.Cargo
{
    public class UpdateCargoDto
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}

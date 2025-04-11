using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.DTO_s.Cargo
{
    public class CreateCargoDto
    {
        public string Description { get; set; }
        public double Weight { get; set; }
       // public string Destination { get; set; }
       // public DateTime DepartureDate { get; set; }
       public int CustomerId {  get; set; } // here I'm assigned  cargo to customer
    }
}

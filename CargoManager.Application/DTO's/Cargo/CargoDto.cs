using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.DTO_s.Cargo
{
    public class CargoDto
    {
        public int Id { get; set; }
        //public string Name { get; set; }
        public string Description {  get; set; }
        public double Weight { get; set; }
       // public string Destination { get; set; }
        //public DateTime DepartureDate { get; set; }

        public int CustomerId {  get; set; } // Here I'm Linking to customer
    }
}

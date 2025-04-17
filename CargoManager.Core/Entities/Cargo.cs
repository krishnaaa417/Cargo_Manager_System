using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Core.Entities
{
    public class Cargo
    {
        public int Id { get; set; }
        //public string Name { get; set; }
        public string Description {  get; set; }

        public double Weight { get; set; }
        // public string Destination { get; set; }
        //public DateTime DepartureDate { get; set; }

        public int? CustomerId { get; set; } // here I'm created FK  relationship
        public Customer Customer { get; set; } //Navigation

        public ICollection<CargoTracking> Trackings { get; set; }
    }
}

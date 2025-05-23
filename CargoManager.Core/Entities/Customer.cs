﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }  // Primary Key
        public string Name { get; set; }
        // public string Email { get; set; }
        // public string Phone { get; set; }

        public string Email { get; set; } = null!;  // ✅ Add this
        public string Phone { get; set; } = null!;  // ✅ Add this
        public string Address { get; set; }

        /// My Navigation Propertyy
        public ICollection<Cargo> Cargos { get; set; } = new List<Cargo>();
    }
}

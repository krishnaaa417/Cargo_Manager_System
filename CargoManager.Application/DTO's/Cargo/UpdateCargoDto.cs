using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.DTO_s.Cargo
{
    public class UpdateCargoDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Weight { get; set; }
        public int CustomerId { get; set; }
        //public DateTime DepartureDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.DTO_s.Invoices
{
    public class CreateInvoiceDto
    {
        public int CargoId { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
    }
}

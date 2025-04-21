using CargoManager.Application.DTO_s.Invoices;
using CargoManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Interfaces
{
    public interface IInvoiceService
    {
        //Task<InvoiceDto> CreateInvoiceAsync(CreateInvoiceDto dto);
        //Task<IEnumerable<InvoiceDto>> GetAllInvoicesAsync();
        //Task<InvoiceDto?> GetInvoiceByNumberAsync(string invoiceNumber);

        Task<Invoice> CreateInvoiceAsync(int customerId, int cargoId, decimal amount);
        Task<Invoice?> GetInvoiceAsync(int id);
    }
}

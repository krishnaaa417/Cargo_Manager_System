using CargoManager.Core.Entities;
using CargoManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Infrastructure.Repositories.Invoices
{
    public interface IInvoiceRepository
    {
        Task<Invoice> AddAsync(Invoice invoice);

        Task<Invoice?> GetByIdAsync(int id);
        //Task AddAsync(Invoice invoice);
        //Task GetAllAsync();
        //Task GetByInvoiceNumberAsync(string invoiceNumber);
        //Task SaveAsync();

        //public interface IInvoiceRepository : IGenericRepository<Invoice>
        //{
        //    Task<Invoice> AddAsync(Invoice invoice);
        //    Task SaveAsync();
        //    Task<IEnumerable<Invoice>> GetAllAsync();
        //    Task<Invoice?> GetByInvoiceNumberAsync(string invoiceNumber);
        //}
    }
}

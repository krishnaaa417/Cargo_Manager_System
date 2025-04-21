using CargoManager.Core.Entities;
using CargoManager.Infrastructure.Data;
using CargoManager.Infrastructure.Repositories.Genric;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Infrastructure.Repositories.Invoices
{
    public class InvoiceRepository : GenericRepository<Invoice>, IInvoiceRepository
    {
        private readonly AppDbContext _context;

        public InvoiceRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Invoice> AddAsync(Invoice invoice)
        {
            if (invoice == null)
            {
                throw new ArgumentNullException(nameof(invoice));
            }

            await _context.Invoices.AddAsync(invoice);
            await _context.SaveChangesAsync();
            return invoice;
        }

        public async Task<Invoice?> GetByIdAsync(int id)
        {
            return await _context.Invoices
                .Include(i => i.Cargo)
                .Include(i => i.Customer)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        //public async Task<Invoice> AddAsync(Invoice invoice)
        //{
        //    await _context.Invoices.AddAsync(invoice);
        //    return invoice;
        //}

        //public Task GetByInvoiceNumberAsync(string invoiceNumber)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task SaveAsync()
        //{
        //    await _context.SaveChangesAsync();
        //}

        //Task IInvoiceRepository.AddAsync(Invoice invoice)
        //{

        //    return _context.Invoices.AddAsync(invoice);
        //}

        //Task IInvoiceRepository.GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IEnumerable<Invoice>> GetAllAsync()
        //{
        //    return await _context.Invoices
        //        .Include(i => i.Cargo)
        //        .Include(i => i.Customer)
        //        .ToListAsync();
        //}

        //public async Task<Invoice?> GetByInvoiceNumberAsync(string invoiceNumber)
        //{
        //    return await _context.Invoices
        //        .Include(i => i.Cargo)
        //        .Include(i => i.Customer)
        //        .FirstOrDefaultAsync(i => i.InvoiceNumber == invoiceNumber);
        //}
    }
}

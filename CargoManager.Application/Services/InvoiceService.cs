using AutoMapper;
using CargoManager.Application.DTO_s.Invoices;
using CargoManager.Application.Interfaces;
using CargoManager.Core.Entities;
using CargoManager.Infrastructure.Repositories.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Services
{
    public class InvoiceService 
    {
        //private readonly IInvoiceRepository _invoiceRepository;
        //private readonly IMapper _mapper;

        //public InvoiceService(IInvoiceRepository invoiceRepository, IMapper mapper)
        //{
        //    _invoiceRepository = invoiceRepository;
        //    _mapper = mapper;
        //}

        //public async Task<Invoice> CreateInvoiceAsync(int customerId, int cargoId, decimal amount)
        //{
        //    var invoice = new Invoice
        //    {
        //        CustomerId = customerId,
        //        CargoId = cargoId,
        //        Amount = amount,
        //        InvoiceDate = DateTime.UtcNow,
        //        InvoiceNumber = $"INV-{new Random().Next(1000, 9999)}"
        //    };

        //    return await _invoiceRepository.AddAsync(invoice);
        //}

        //public async Task<Invoice?> GetInvoiceAsync(int id)
        //{
        //    return await _invoiceRepository.GetByIdAsync(id);
        //}

        //public async Task<InvoiceDto> CreateInvoiceAsync(CreateInvoiceDto dto)
        //{
        //    var invoice = new Invoice
        //    {
        //        CargoId = dto.CargoId,
        //        CustomerId = dto.CustomerId,
        //        Amount = dto.Amount,
        //        InvoiceDate = DateTime.UtcNow,
        //        InvoiceNumber = GenerateInvoiceNumber(),
        //        Status = "Pending"
        //    };

        //    await _invoiceRepository.AddAsync(invoice);
        //    await _invoiceRepository.SaveAsync();

        //    return _mapper.Map<InvoiceDto>(invoice);
        //}

        //public async Task<IEnumerable<InvoiceDto>> GetAllInvoicesAsync()
        //{
        //    var invoices = await _invoiceRepository.GetAllAsync();
        //    return _mapper.Map<IEnumerable<InvoiceDto>>(invoices);
        //}

        //public async Task<InvoiceDto?> GetInvoiceByNumberAsync(string invoiceNumber)
        //{
        //    var invoice = await _invoiceRepository.GetByInvoiceNumberAsync(invoiceNumber);
        //    return invoice == null ? null : _mapper.Map<InvoiceDto>(invoice);
        //}

        private string GenerateInvoiceNumber()
        {
            return $"INV-{DateTime.UtcNow:yyyyMMddHHmmssfff}";
        }
    }
}

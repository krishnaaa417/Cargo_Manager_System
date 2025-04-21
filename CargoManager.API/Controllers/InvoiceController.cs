using CargoManager.Application.DTO_s.Invoices;
using CargoManager.Application.Interfaces;
using CargoManager.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CargoManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }


        [HttpPost("create")]
        public async Task<IActionResult> CreateInvoice([FromBody] Invoice invoice)
        {
            if (invoice == null)
            {
                return BadRequest("Invoice data is required.");
            }

            var createdInvoice = await _invoiceService.CreateInvoiceAsync(invoice.CustomerId, invoice.CargoId, invoice.Amount);
            return Ok(createdInvoice);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetInvoice(int id)
        {
            var invoice = await _invoiceService.GetInvoiceAsync(id);
            if (invoice == null) return NotFound("Invoice not found.");

            return Ok(invoice);
        }

        // POST: api/Invoice
        //[HttpPost]
        //public async Task<IActionResult> CreateInvoice([FromBody] CreateInvoiceDto dto)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    var createdInvoice = await _invoiceService.CreateInvoiceAsync(dto);
        //    return CreatedAtAction(nameof(GetInvoiceByNumber), new { invoiceNumber = createdInvoice.InvoiceNumber }, createdInvoice);
        //}

        //// GET: api/Invoice
        //[HttpGet]
        //public async Task<IActionResult> GetAllInvoices()
        //{
        //   // var invoices = await _invoiceService.GetAllInvoicesAsync();
        //    return Ok();
        //}

        //// GET: api/Invoice/{invoiceNumber}
        //[HttpGet("{invoiceNumber}")]
        //public async Task<IActionResult> GetInvoiceByNumber(string invoiceNumber)
        //{
        //    //var invoice = await _invoiceService.GetInvoiceByNumberAsync(invoiceNumber);
        //    //if (invoice == null)
        //    //    return NotFound($"Invoice with number {invoiceNumber} not found.");

        //    return Ok();
        //}
    }
}

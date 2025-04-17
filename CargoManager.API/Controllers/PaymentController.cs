using CargoManager.Application.DTO_s.PayDTO_s;
using CargoManager.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CargoManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreatePayment(CreatePaymentDto dto)
        {
            var orderId = await _paymentService.CreatePaymentAsync(dto);
            return Ok(new { OrderId = orderId });
        }

        [HttpPost("verify")]
        public async Task<IActionResult> VerifyPayment(VerifyPaymentDto dto)
        {
            var isValid = await _paymentService.VerifyPaymentAsync(dto);
            return Ok(new { Success = isValid });
        }
    }
}

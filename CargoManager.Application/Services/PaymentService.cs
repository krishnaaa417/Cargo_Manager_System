using CargoManager.Application.DTO_s.PayDTO_s;
using CargoManager.Application.Interfaces;
using CargoManager.Core.Interfaces;
using CargoManager.Infrastructure.Repositories.RazorPay;
using Razorpay.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Payment = CargoManager.Core.Entities.Payment;


namespace CargoManager.Application.Services
{
    public class PaymentService 
    {
        //private readonly IPaymentRepository _paymentRepository;
        // private string razorpayOrderId;

        //private readonly IPaymentRepository _paymentRepository;

        //public PaymentService(IPaymentRepository paymentRepository)
        //{
        //    _paymentRepository = paymentRepository;
        //}

        //public async Task<string> CreatePaymentAsync(CreatePaymentDto dto)
        //{
        //    RazorpayClient client = new RazorpayClient("rzp_test_iS4ZXWqjE5NVAq", "Y938V0KAAzaJIketwxBQOTlB");

        //    Dictionary<string, object> options = new()
        //    {
        //        { "amount", dto.Amount * 100 },
        //        { "currency", "INR" },
        //        { "payment_capture", 1 }
        //    };

        //    Order order = client.Order.Create(options);

        //    string razorpayOrderId = order["id"].ToString();

        //    var payment = new Payment
        //    {
        //        RazorpayOrderId = order["id"].ToString(),
        //        RazorpayPaymentId = null, // will be updated after payment
        //        RazorpaySignature = null, // will be updated after verification
        //        Amount = dto.Amount,
        //        IsPaid = false,
        //        Status = "Created"
        //    };


        //    await _paymentRepository.AddAsync(payment);
        //    //return order["id"].ToString();
        //    return order["id"].ToString();
        //    Console.WriteLine($"RazorpayPaymentId: {payment.RazorpayPaymentId}");

        //}

        //public async Task<bool> VerifyPaymentAsync(VerifyPaymentDto dto)
        //{
        //    var payment = await _paymentRepository.GetByOrderIdAsync(dto.RazorpayOrderId);
        //    if (payment == null) return false;

        //    string generatedSignature = GetSignature(dto.RazorpayOrderId, dto.RazorpayPaymentId, "Y938V0KAAzaJIketwxBQOTlB");
        //    if (generatedSignature != dto.RazorpaySignature) return false;

        //    payment.RazorpayPaymentId = dto.RazorpayPaymentId;
        //    payment.RazorpaySignature = dto.RazorpaySignature;
        //    payment.IsPaid = true;

        //    //await _paymentRepository.UpdateAsync(payment);
        //    return true;
        //}

        private string GetSignature(string orderId, string paymentId, string secret)
        {
            string data = orderId + "|" + paymentId;
            var encoding = new ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(data);
            using var hmacsha256 = new HMACSHA256(keyByte);
            byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
            return BitConverter.ToString(hashmessage).Replace("-", "").ToLower();
        }
    }
}

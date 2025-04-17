using AutoMapper;
using CargoManager.Application.DTO_s.PayDTO_s;
using CargoManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Mappings
{
    public class PaymentMapping : Profile
    {
        public PaymentMapping()
        {
            CreateMap<Payment, CreatePaymentDto>().ReverseMap();
            CreateMap<Payment, PaymentDto>().ReverseMap();
        }
    }
}

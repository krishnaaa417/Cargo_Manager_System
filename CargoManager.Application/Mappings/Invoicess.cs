using AutoMapper;
using CargoManager.Application.DTO_s.Invoices;
using CargoManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Mappings
{
    public class Invoicess : Profile
    {
        public Invoicess()
        {
            //CreateMap<Invoice, InvoiceDto>().ReverseMap();
            //CreateMap<CreateInvoiceDto, Invoice>();
        }
    }
}

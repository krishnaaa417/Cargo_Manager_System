using AutoMapper;
using CargoManager.Application.DTO_s.CargoTrackingDtos;
using CargoManager.Application.DTO_s.Customer;
using CargoManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Mappings
{
    public class CustomerMapper : Profile
    {
        public CustomerMapper()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<CreateCustomerDto, Customer>();

            
        }
    }
}

using AutoMapper;
using CargoManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Mappings
{
    public class Deliveries : Profile
    {
        public Deliveries()
        {
            CreateMap<Delivery, DeliveryDto>().ReverseMap();
            CreateMap<CreateDeliveryDto, Delivery>();
            CreateMap<UpdateDeliveryDto, Delivery>();

        }
    }
}

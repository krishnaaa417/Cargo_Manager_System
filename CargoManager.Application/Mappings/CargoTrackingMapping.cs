using AutoMapper;
using CargoManager.Application.DTO_s.CargoTrackingDtos;
using CargoManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Mappings
{
    public class CargoTrackingMapping : Profile
    {
        public CargoTrackingMapping()
        {
            CreateMap<CargoTracking, CreateCargoTrackingDto>().ReverseMap();
            CreateMap<CargoTracking, UpdateCargoTrackingDto>().ReverseMap();
            CreateMap<CargoTracking,CargoTrackingDto>().ReverseMap();
        }
    }
}

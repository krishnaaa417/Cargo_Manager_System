using AutoMapper;
using CargoManager.Application.DTO_s.Cargo;
using CargoManager.Application.DTO_s.CargoTrackingDtos;
using CargoManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Mappings
{
    public class CargoProfile : Profile
    {
        public CargoProfile()
        {
            CreateMap<CargoProfile, CargoDto>().ReverseMap();
            CreateMap<CargoProfile, CreateCargoDto>().ReverseMap();
            CreateMap<CargoProfile, UpdateCargoDto>().ReverseMap();

           
        }
    }
}

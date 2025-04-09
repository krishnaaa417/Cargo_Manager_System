using AutoMapper;
using CargoManager.Application.DTO_s.Cargo;
using CargoManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Mappings
{
   public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cargo, CargoDto>().ReverseMap();
            CreateMap<Cargo, CreateCargoDto>().ReverseMap();
            CreateMap<Cargo, UpdateCargoDto>().ReverseMap();
        }
    }
}

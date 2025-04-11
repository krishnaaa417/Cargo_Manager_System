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
    public class UpdateDCargo : Profile
    {
        public UpdateDCargo()
        {
            CreateMap<Cargo, CargoDto>().ReverseMap();
            CreateMap<CreateCargoDto, Cargo>();
        }
    }
}

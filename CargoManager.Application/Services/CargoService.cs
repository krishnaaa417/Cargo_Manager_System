using AutoMapper;
using CargoManager.Application.DTO_s.Cargo;
using CargoManager.Application.Interfaces;

using CargoManager.Core.Entities;
using CargoManager.Core.Interfaces;
using CargoManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Services
{
    public class CargoService : ICargoService
    {

        private readonly IGenericRepository<Cargo> _repository;
        private readonly IMapper _mapper;

        public CargoService(IGenericRepository<Cargo> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CargoDto>> GetAllAsync()
        {
            var cargos = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<CargoDto>>(cargos);
        }

        public async Task<CargoDto> GetByIdAsync(int id)
        {
            var cargo = await _repository.GetByIdAsync(id);
            return _mapper.Map<CargoDto>(cargo);
        }

        public async Task<CargoDto> CreateAsync(CreateCargoDto dto)
        {
            var cargo = _mapper.Map<Cargo>(dto);
           var createdEntity =  await _repository.AddAsync(cargo);
            return _mapper.Map<CargoDto>(createdEntity);
        }

        public async Task UpdateAsync(UpdateCargoDto dto)
        {
            var cargo = _mapper.Map<Cargo>(dto);
            _repository.Update(cargo);
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var cargo = await _repository.GetByIdAsync(id);
            _repository.Delete(cargo);
            await _repository.SaveAsync();
        }

        public async Task<CargoDto> AddAsync(CreateCargoDto dto)
        {
            var cargo = _mapper.Map<Cargo>(dto);
            await _repository.AddAsync(cargo);
            await _repository.SaveAsync();
            return _mapper.Map<CargoDto>(cargo);
        }


    }
}

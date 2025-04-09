using AutoMapper;
using CargoManager.Application.DTO_s.Cargo;
using CargoManager.Application.Interfaces;
using CargoManager.Application.Interfaces.Repository;
using CargoManager.Core.Entities;
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
        private readonly IGenericRepository<Cargo> _cargoRepository;
        private readonly IMapper _mapper;

        public CargoService(IGenericRepository<Cargo> cargoRepository, IMapper mapper)
        {
            _cargoRepository = cargoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CargoDto>> GetAllAsync()
        {
            var cargos = await _cargoRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CargoDto>>(cargos);
        }

        public async Task<CargoDto> GetByIdAsync(int id)
        {
            var cargo = await _cargoRepository.GetByIdAsync(id);
            return _mapper.Map<CargoDto>(cargo);
        }

        public async Task<CargoDto> CreateAsync(CreateCargoDto dto)
        {
            var cargo = _mapper.Map<Cargo>(dto);
            await _cargoRepository.AddAsync(cargo);
            return _mapper.Map<CargoDto>(cargo);
        }

        public async Task<bool> UpdateAsync(int id, UpdateCargoDto dto)
        {
            var cargo = await _cargoRepository.GetByIdAsync(id);
            if (cargo == null) return false;

            _mapper.Map(dto, cargo);
            await _cargoRepository.UpdateAsync(cargo);
            return true;
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        //public async Task<bool> DeleteAsync(int id)
        //{
        //    var cargo = await _cargoRepository.GetByIdAsync(id);
        //    if (cargo == null) return false;

        //    await _cargoRepository.DeleteAsync(cargo);
        //    return true;
        //}
    }
}

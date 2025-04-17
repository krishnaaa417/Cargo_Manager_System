using AutoMapper;
using CargoManager.Application.DTO_s.CargoTrackingDtos;
using CargoManager.Application.Interfaces;
using CargoManager.Core.Entities;
using CargoManager.Core.Interfaces;
using CargoManager.Infrastructure.Repositories.CargoTrackings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Services
{
    public class CargoTrackingService : ICargoTrackingService
    {
        private readonly ICargoTrackingRepository _repository;
        private readonly IMapper _mapper;

        public CargoTrackingService(ICargoTrackingRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CargoTrackingDto>> GetAllAsync()
        {
            var trackings = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<CargoTrackingDto>>(trackings);
        }

        public async Task<CargoTrackingDto> GetByIdAsync(int id)
        {
            var tracking = await _repository.GetByIdAsync(id);
            return _mapper.Map<CargoTrackingDto>(tracking);
        }

        public async Task<IEnumerable<CargoTrackingDto>> GetByCargoIdAsync(int cargoId)
        {
            var trackings = await _repository.GetByCargoIdAsync(cargoId);
            return _mapper.Map<IEnumerable<CargoTrackingDto>>(trackings);
        }

        public async Task<CargoTrackingDto> CreateAsync(CreateCargoTrackingDto dto)
        {
            var entity = _mapper.Map<CargoTracking>(dto);
            entity.UpdatedAt = DateTime.UtcNow;

            await _repository.AddAsync(entity);
            return _mapper.Map<CargoTrackingDto>(entity);
        }

        public async Task<bool> UpdateAsync(UpdateCargoTrackingDto dto)
        {
            var existing = await _repository.GetByIdAsync(dto.Id);
            if (existing == null) return false;

            _mapper.Map(dto, existing);
            existing.UpdatedAt = DateTime.UtcNow;

            _repository.Update(existing); // sync method now
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null) return false;

            _repository.Delete(existing); // sync method now
            return true;
        }
    }
}

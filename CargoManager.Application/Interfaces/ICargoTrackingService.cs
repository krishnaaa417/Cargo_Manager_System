using CargoManager.Application.DTO_s.CargoTrackingDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Interfaces
{
    public interface ICargoTrackingService
    {
        Task<IEnumerable<CargoTrackingDto>> GetAllAsync();
        Task<CargoTrackingDto> GetByIdAsync(int id);
        Task<IEnumerable<CargoTrackingDto>> GetByCargoIdAsync(int cargoId);
        Task<CargoTrackingDto> CreateAsync(CreateCargoTrackingDto dto);
        Task<bool> UpdateAsync(UpdateCargoTrackingDto dto);
        Task<bool> DeleteAsync(int id);
    }
}

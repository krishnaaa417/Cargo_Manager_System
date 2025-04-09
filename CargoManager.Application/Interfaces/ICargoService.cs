using CargoManager.Application.DTO_s.Cargo;
using CargoManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Interfaces
{
    public interface ICargoService
    {
        Task<IEnumerable<CargoDto>> GetAllAsync();
        Task<CargoDto> GetByIdAsync(int id);
        Task<CargoDto> CreateAsync(CreateCargoDto dto);
        Task<bool> UpdateAsync(int id, UpdateCargoDto dto);
        Task<bool> DeleteAsync(int id);
    }
}

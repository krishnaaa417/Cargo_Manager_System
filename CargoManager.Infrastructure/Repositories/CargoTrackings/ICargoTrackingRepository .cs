using CargoManager.Core.Entities;
using CargoManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Infrastructure.Repositories.CargoTrackings
{
    public interface ICargoTrackingRepository : IGenericRepository<CargoTracking>
    {
        Task<IEnumerable<CargoTracking>> GetByCargoIdAsync(int cargoId);
    }
}

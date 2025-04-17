using CargoManager.Core.Entities;
using CargoManager.Infrastructure.Data;
using CargoManager.Infrastructure.Repositories.Genric;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Infrastructure.Repositories.CargoTrackings
{
    public class CargoTrackingRepository : GenericRepository<CargoTracking>, ICargoTrackingRepository
    {
        private readonly AppDbContext _appDbContext;
        public CargoTrackingRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }

        public async Task<IEnumerable<CargoTracking>> GetByCargoIdAsync(int cargoId)
        {
            return await _appDbContext.CargoTrackings
                                                    .Where(ct => ct.CargoId == cargoId).ToListAsync();
                                                        
        }
    }
}

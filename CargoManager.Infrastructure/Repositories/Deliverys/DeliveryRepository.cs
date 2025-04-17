using CargoManager.Core.Entities;
using CargoManager.Infrastructure.Data;
using CargoManager.Infrastructure.Repositories.Genric;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Infrastructure.Repositories.Deliverys
{
    public class DeliveryRepository : GenericRepository<Delivery>, IDeliveryRepository
    {
       // private readonly AppDbContext _appDbContext;

        private readonly AppDbContext _appDbContext;

        public DeliveryRepository(AppDbContext appDbContext) : base(appDbContext) // ✅ FIX HERE
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Delivery>> GetDeliveriesByCargoIdAsync(int cargoId)
        {
            return await _appDbContext.Deliveries
                .Where(d => d.CargoId == cargoId)
                .ToListAsync();
        }
    }
}

using CargoManager.Core.Entities;
using CargoManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Infrastructure.Repositories.Deliverys
{
    public interface IDeliveryRepository : IGenericRepository<Delivery>
    {
        Task<IEnumerable<Delivery>> GetDeliveriesByCargoIdAsync(int cargoId);
    }
}

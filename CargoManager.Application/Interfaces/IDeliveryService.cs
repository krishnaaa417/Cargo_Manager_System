using CargoManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Interfaces
{
    public interface IDeliveryService
    {
        Task<IEnumerable<DeliveryDto>> GetAllDeliveriesAsync();
        Task<DeliveryDto> GetDeliveryByIdAsync(int id);
        Task<DeliveryDto> CreateDeliveryAsync(CreateDeliveryDto dto);
        Task<bool> UpdateDeliveryAsync(int id, UpdateDeliveryDto dto);
        Task<bool> DeleteDeliveryAsync(int id);
    }
}

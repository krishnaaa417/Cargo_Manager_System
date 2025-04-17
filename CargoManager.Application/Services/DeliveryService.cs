using AutoMapper;
using CargoManager.Application.Interfaces;
using CargoManager.Core.Entities;
using CargoManager.Infrastructure.Repositories.Deliverys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Services
{
    public class DeliveryService : IDeliveryService
    {
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IMapper _mapper;

        public DeliveryService(IDeliveryRepository deliveryRepository, IMapper mapper)
        {
            _deliveryRepository = deliveryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DeliveryDto>> GetAllDeliveriesAsync()
        {
            var deliveries = await _deliveryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<DeliveryDto>>(deliveries);
        }

        public async Task<DeliveryDto> GetDeliveryByIdAsync(int id)
        {
            var delivery = await _deliveryRepository.GetByIdAsync(id);
            return _mapper.Map<DeliveryDto>(delivery);
        }

        public async Task<DeliveryDto> CreateDeliveryAsync(CreateDeliveryDto dto)
        {
            var delivery = _mapper.Map<Delivery>(dto);
            var created = await _deliveryRepository.AddAsync(delivery);
            await _deliveryRepository.SaveAsync();
            return _mapper.Map<DeliveryDto>(created);
        }

        public async Task<bool> UpdateDeliveryAsync(int id, UpdateDeliveryDto dto)
        {
            var delivery = await _deliveryRepository.GetByIdAsync(id);
            if (delivery == null) return false;

            _mapper.Map(dto, delivery);
            _deliveryRepository.Update(delivery);
            await _deliveryRepository.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteDeliveryAsync(int id)
        {
            var delivery = await _deliveryRepository.GetByIdAsync(id);
            if (delivery == null) return false;

            _deliveryRepository.Delete(delivery);
            await _deliveryRepository.SaveAsync();
            return true;
        }
    }
}

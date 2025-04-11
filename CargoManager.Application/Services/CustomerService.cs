using AutoMapper;
using CargoManager.Application.DTO_s.Customer;
using CargoManager.Application.Interfaces;
using CargoManager.Core.Entities;
using CargoManager.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CustomerDto>> GetAllAsync()
        {
            var customers = await _customerRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CustomerDto>>(customers);
        }

        public async Task<CustomerDto> GetByIdAsync(int id)
        {
            var customer = await _customerRepository.GetByIdAsync(id);
            return _mapper.Map<CustomerDto>(customer);
        }

        public async Task AddAsync(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            await _customerRepository.AddAsync(customer);
            await _customerRepository.SaveAsync();
        }

        public async Task UpdateAsync(int id, CustomerDto customerDto)
        {
            var existing = await _customerRepository.GetByIdAsync(id);
            if (existing is null)
                throw new Exception($"Customer with ID {id} not found");

            _mapper.Map(customerDto, existing);
            _customerRepository.Update(existing);
            await _customerRepository.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var customer = await _customerRepository.GetByIdAsync(id);
            if (customer is null)
                throw new Exception($"Customer with ID {id} not found");

            _customerRepository.Delete(customer);
            await _customerRepository.SaveAsync();
        }
    }
}

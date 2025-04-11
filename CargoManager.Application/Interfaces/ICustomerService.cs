using CargoManager.Application.DTO_s.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Application.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDto>> GetAllAsync();
        Task<CustomerDto> GetByIdAsync(int id);
        Task AddAsync(CustomerDto customerDto);
        Task UpdateAsync(int id, CustomerDto customerDto);
        Task DeleteAsync(int id);
    }
}

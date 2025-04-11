using CargoManager.Application.DTO_s.Customer;
using CargoManager.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CargoManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _customerService.GetAllAsync();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var customer = await _customerService.GetByIdAsync(id);
            return customer is not null ? Ok(customer) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerDto customerDto)
        {
            await _customerService.AddAsync(customerDto);
            return Ok(new { message = "Customer created successfully" });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CustomerDto customerDto)
        {
            await _customerService.UpdateAsync(id, customerDto);
            return Ok(new { message = "Customer updated successfully" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _customerService.DeleteAsync(id);
            return Ok(new { message = "Customer deleted successfully" });
        }
    }
}

using CargoManager.Application.DTO_s.CargoTrackingDtos;
using CargoManager.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CargoManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoTrackingController : ControllerBase
    {
        private readonly ICargoTrackingService _service;

        public CargoTrackingController(ICargoTrackingService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CargoTrackingDto>>> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CargoTrackingDto>> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet("cargo/{cargoId}")]
        public async Task<ActionResult<IEnumerable<CargoTrackingDto>>> GetByCargoId(int cargoId)
        {
            var result = await _service.GetByCargoIdAsync(cargoId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<CargoTrackingDto>> Create(CreateCargoTrackingDto dto)
        {
            var result = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut]
        public async Task<ActionResult> Update(UpdateCargoTrackingDto dto)
        {
            var updated = await _service.UpdateAsync(dto);
            if (!updated) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}

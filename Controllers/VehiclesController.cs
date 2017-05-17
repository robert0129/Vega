using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationBasic.Controllers.Resources;

namespace WebApplicationBasic.Controllers
{
    public class VehiclesController : Controller
    {
        public VehiclesController() { }

        [HttpGet("/api/vehicles")]
        public async Task<IActionResult> GetVehicles()
        {
            await Task.FromResult(0);
            return Ok();
        }

        [HttpGet("/api/vehicles/{id}")]
        public async Task<IActionResult> GetVehicles(int id)
        {
            await Task.FromResult(0);
            return Ok();
        }

        [HttpPost("/api/vehicles")]
        public async Task<IActionResult> PostVehicles([FromBody] VehicleFeature vehicleFeature)
        {
            await Task.FromResult(0);
            return Ok();
        }

        [HttpPut("/api/vehicles")]
        public async Task<IActionResult> PutVehicles([FromBody] VehicleFeature vehicleFeature)
        {
            await Task.FromResult(0);
            return Ok();
        }

        [HttpDelete("/api/vehicles/{id}")]
        public async Task<IActionResult> DeleteVehicles(int id)
        {
            await Task.FromResult(0);
            return Ok();
        }
    }
}
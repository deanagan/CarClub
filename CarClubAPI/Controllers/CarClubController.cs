using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using CarClubAPI.Data;
using CarClubAPI.Models;

namespace CarClubAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarClubController : ControllerBase
    {
        private CarClubContext _context;
        private readonly ILogger<CarClubController> _logger;

        public CarClubController(CarClubContext context, ILogger<CarClubController> logger)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("[action]")]
        public IActionResult GetAllVehicles()
        {

            var vehicleEntries =
                        from plateNumbers in _context.PlateNumbers
                        join vehiclesList in _context.Vehicles
                        on plateNumbers.Id equals vehiclesList.Id
                        select new
                        {
                            plate_numbers = plateNumbers.Number,
                            vehicles = new {
                                    make = vehiclesList.Make,
                                    model = vehiclesList.Model
                            }
                        };
            return Ok(vehicleEntries.ToList());
        }
    }
}

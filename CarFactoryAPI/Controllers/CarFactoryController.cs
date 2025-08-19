using Microsoft.AspNetCore.Mvc;

namespace CarFactoryApi.Controllers
{
    [ApiController]
    public class CarFactoryController(CarFactory carFactory) : ControllerBase
    {
        private readonly CarFactory _carFactory = carFactory;

        [HttpGet("api/buildcar")]
        public IActionResult BuildCar()
        {
            var result = _carFactory.BuildCar();
            return Ok(result);
        }
    }
}
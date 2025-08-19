using Microsoft.AspNetCore.Mvc;

namespace CarFactoryApi.Controllers
{
    [ApiController]
    [Route("api/car")]
    public class CarFactoryController(CarFactory carFactory) : ControllerBase
    {
        private readonly CarFactory _carFactory = carFactory;

        [HttpGet("build")]
        public IActionResult BuildCar()
        {
            var result = _carFactory.BuildCar();
            return Ok(result);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using CarApi.Models;

namespace CarApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private static List<Car> Cars = new List<Car>
        {
            new Car { Id = 1, Make = "Toyota", Model = "Corolla", Year = 2020 },
            new Car { Id = 2, Make = "Honda", Model = "Civic", Year = 2019 }
        };

        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return Cars;
        }

        [HttpGet("{id}")]
        public ActionResult<Car> Get(int id)
        {
            var car = Cars.FirstOrDefault(c => c.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            return car;
        }
    }
}

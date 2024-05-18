using Microsoft.AspNetCore.Mvc;
using CarApi.Models;

namespace CarApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OwnerController : ControllerBase
    {
        private static List<Owner> Owners = new List<Owner>
        {
            new Owner { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
            new Owner { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" }
        };

        [HttpGet]
        public IEnumerable<Owner> Get()
        {
            return Owners;
        }

        [HttpGet("{id}")]
        public ActionResult<Owner> Get(int id)
        {
            var owner = Owners.FirstOrDefault(o => o.Id == id);
            if (owner == null)
            {
                return NotFound();
            }
            return owner;
        }
    }
}

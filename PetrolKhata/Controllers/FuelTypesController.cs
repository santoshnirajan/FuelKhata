using Microsoft.AspNetCore.Mvc;
using PetrolKhata.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetrolKhata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelTypesController : ControllerBase
    {
        public FuelKhataDbContext dbContext;
        public FuelTypesController(FuelKhataDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<FuelTypesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FuelTypesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FuelTypesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FuelTypesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FuelTypesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public static implicit operator FuelTypesController(FuelKhataDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}

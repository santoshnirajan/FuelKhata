using Microsoft.AspNetCore.Mvc;
using PetrolKhata.Data;
using PetrolKhata.Model;

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
        public IActionResult Get()
        {
            var fueltypelist= dbContext.FuelTypes.ToList();
            return Ok (fueltypelist);
        }

        // GET api/<FuelTypesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var selectedFuelType =dbContext.FuelTypes.FirstOrDefault(f => f.Id == id);
            return Ok (selectedFuelType);
        }

        // POST api/<FuelTypesController>
        [HttpPost]
        public IActionResult Post([FromBody] FuelType value)
        {
            FuelType fuelType = new FuelType();
            fuelType.Fuel = value.Fuel;
            dbContext.Add(fuelType);
            dbContext.SaveChanges();
            return Ok(fuelType);
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

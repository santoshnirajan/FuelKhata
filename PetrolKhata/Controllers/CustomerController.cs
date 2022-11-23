using Microsoft.AspNetCore.Mvc;
using PetrolKhata.Data;
using PetrolKhata.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetrolKhata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public FuelKhataDbContext dbContext;
        public CustomerController(FuelKhataDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]
        public IActionResult Post([FromBody] Customer value)
        {
            Customer customer = new Customer();
            customer.FirstName = value.FirstName;
            customer.LastName = value.LastName; 
            customer.Address = value.Address;
            customer.PhoneNumber = value.PhoneNumber;
            customer.IsDelete = false;
            dbContext.Add(customer);
            dbContext.SaveChanges();

            return Ok(customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public static implicit operator CustomerController(FuelKhataDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}

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
        public CustomerController(FuelKhataDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public IActionResult Get()
        {
            var customerList = dbContext.Customers.Where(x=>x.IsDelete==false).ToList();
            return Ok(customerList);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var selectedCustomer=dbContext.Customers.SingleOrDefault(x => x.Id == id);
            return Ok(selectedCustomer);
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
        public IActionResult Put(int id, [FromBody] Customer value)
        {
            var customer = dbContext.Customers.Where(x => x.Id == id).FirstOrDefault();
            customer.FirstName = value.FirstName;
            customer.LastName = value.LastName;
            customer.Address = value.Address;
            customer.PhoneNumber = value.PhoneNumber;
            customer.IsDelete = false;
            dbContext.SaveChanges();

            return Ok(customer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var customer = dbContext.Customers.Where(x => x.Id == id).FirstOrDefault();
            customer.IsDelete = true;
            dbContext.SaveChanges();
        }

        public static implicit operator CustomerController(FuelKhataDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}

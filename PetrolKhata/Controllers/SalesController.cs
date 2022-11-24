using Microsoft.AspNetCore.Mvc;
using PetrolKhata.Data;
using PetrolKhata.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetrolKhata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        public FuelKhataDbContext dbContext;
        public SalesController(FuelKhataDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET: api/<SalesController>
        [HttpGet]
        public IActionResult Get()
        {
            var salesList=dbContext.Sale.ToList();
            return Ok(salesList);
        }

        // GET api/<SalesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SalesController>
        [HttpPost("{fuelId}/{customerId}")]
        public IActionResult Post([FromBody] Sales value, int fuelId, int customerId)
        {
            Sales sales = new Sales();
            sales.Date = value.Date;
            sales.Quantity = value.Quantity;
            sales.TotalRate = value.TotalRate;
            sales.Remarks = value.Remarks;
            sales.CustomerId = customerId;
            sales.FuelId = fuelId;
            dbContext.Add(sales);
            dbContext.SaveChanges();
            return Ok(sales);
        }

        // PUT api/<SalesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SalesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

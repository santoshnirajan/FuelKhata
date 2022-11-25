using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetrolKhata.Data;
using PetrolKhata.DTO;
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
            var salesList=dbContext.Sale.Include(a => a.FuelType).Include(b => b.Customer).ToList();
            return Ok(salesList);
        }

        // GET api/<SalesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SalesController>
        [HttpPost]
        public IActionResult Post([FromBody] SalesDTO salesDTO)
        {
            try
            {
                if(salesDTO == null)
                {
                    throw new ArgumentNullException(nameof(salesDTO));
                }

                var Customer = dbContext.Customers.Where(a => a.Id == salesDTO.CustomerId).FirstOrDefault();
                var FuelType = dbContext.FuelTypes.Where(a => a.Id == salesDTO.FuelId).FirstOrDefault();

                Sales sales = new Sales();
                sales.Date = salesDTO.Date;
                sales.TotalRate = salesDTO.TotalRate;
                sales.Remarks = salesDTO.Remarks;
                sales.Quantity = salesDTO.Quantity;
                sales.Customer = Customer;
                sales.FuelType = FuelType;
               

                dbContext.Sale.Add(sales);
                dbContext.SaveChanges();
                return Ok(sales.Id);
            }
            catch (Exception ex)
            {

                throw;
            }

            //Sales sales = new Sales();
            //sales.Date = value.Date;
            //sales.Quantity = value.Quantity;
            //sales.TotalRate = value.TotalRate;
            //sales.Remarks = value.Remarks;
            ////sales.CustomerId = customerId;
            ////sales.FuelId = fuelId;
            //dbContext.Add(sales);
            //dbContext.SaveChanges();
            //return Ok(sales);
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

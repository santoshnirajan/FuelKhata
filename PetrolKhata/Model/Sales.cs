using System.ComponentModel.DataAnnotations;

namespace PetrolKhata.Model
{
    public class Sales
    {
        [Key]
        public int Id { get; set; }
        public string Date { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalRate { get; set; }
        public string  Remarks { get; set; }
        //public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        //public int FuelId { get; set; }
        public FuelType FuelType { get; set; }
    }
}

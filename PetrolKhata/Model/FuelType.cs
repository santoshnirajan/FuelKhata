using System.ComponentModel.DataAnnotations;

namespace PetrolKhata.Model
{
    public class FuelType
    {
        [Key]
        public int Id { get; set; }
        public string Fuel { get; set; }
        public decimal Rate { get; set; }
       
    }
}

using System.ComponentModel.DataAnnotations;

namespace PetrolKhata.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsDelete { get; set; }
        //public ICollection<Sales>Sales { get; set; }

        public Customer()
        {
          
            IsDelete = false;
          // Sales = new HashSet<Sales>();
        }

    }
}

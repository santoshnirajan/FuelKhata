namespace PetrolKhata.Model
{
    public class Sales
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalRate { get; set; }
        public string  Remarks { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer;
        public int FuelId { get; set; }
        public FuelType FuelType;
    }
}

namespace PetrolKhata.DTO
{
    public class SalesDTO
    {
        public string Date { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalRate { get; set; }
        public string Remarks { get; set; }
        public int CustomerId { get; set; }
        public int FuelId { get; set; }
    }
}

﻿namespace PetrolKhata.Model
{
    public class FuelType
    {
        public int Id { get; set; }
        public string Fuel { get; set; }
        public ICollection<Sales>Sales { get; set; }
         public FuelType ()
        {
            Sales = new List<Sales> (); 
        }
    }
}

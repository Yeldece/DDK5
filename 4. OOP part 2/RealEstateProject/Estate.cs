using System;
namespace RealEstateProject
{
    public abstract class RealEstate
    {
        public string Location { get; set; }
        public int Area { get; set; }
        public decimal SellPrice { get; set; }
        public decimal RentPrice { get; set; }
        public decimal SaleTax { get => SellPrice * 0.12m; }
        public decimal RentTax { get => RentPrice * 0.05m; }
        public RealEstate(string location)
        {
            Location = location;
        }
    }
}
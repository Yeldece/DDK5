using System;
namespace ClothShoping
{
    public class TShirt : IDiscount, IClothSize, IFabric
    {
        public string Type { get; set; }
        public int BodySize { get; set; }

        public decimal DiscountCalculate(decimal price)
        {
            return price * (decimal)0.07;
        }
    }
}
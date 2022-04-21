using System;
namespace ClothShoping
{
    public class SweetShirt : BaseCloth, IDiscount, IFabric, IClothSize
    {
        public string Type { get; set; }
        public int BodySize { get; set; }

        public decimal DiscountCalculate(decimal price)
        {
            return price * (decimal)0.09;
        }
    }
}
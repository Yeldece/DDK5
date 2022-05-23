using System;
namespace ClothShoping
{
    public class Shoes : BaseCloth, IDiscount
    {
        protected double No { get; set; }
        public decimal DiscountCalculate(decimal price)
        {
            return price * (decimal)0.05;
        }
    }
}
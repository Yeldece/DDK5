using System;
namespace ClothShoping
{
    internal interface IDiscount
    {
        internal decimal DiscountCalculate(decimal price);
    }
}
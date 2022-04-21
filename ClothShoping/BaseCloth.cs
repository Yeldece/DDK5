using System;
namespace ClothShoping
{
    public abstract class BaseCloth
    {
        protected string id { get; set; }
        protected DateTime _AddDate = DateTime.Now;
        protected DateTime AddDate { get => _AddDate; set => _AddDate = value; }
        protected string Colour { get; set; }
        protected decimal Price { get; set; }
        protected decimal PriceWithTax { get => Price * (decimal)0.18; }
        
    }
}
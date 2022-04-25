using System;
namespace Console_review.Modals
{
    /// <summary>
    /// Product class for json version, no constructor yet
    /// </summary>
    class Product
    {
        public int id { get; set; }
        public string? name { get; set; }
        public decimal unitPrice { get; set; }
        public int unitsInStock { get; set; }
        public int categoryId { get; set; }
        public int supplierId { get; set; }
    }
}
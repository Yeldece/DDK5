using System;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Console_review.Models
{
    public class ShipAddress
    {
        [JsonPropertyName("street")]
        public string Street { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        //[JsonPropertyName("postalCode")]
        //public string PostalCode { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }
    }

    public class Detail
    {
        [JsonPropertyName("productId")]
        public int ProductId { get; set; }

        [JsonPropertyName("unitPrice")]
        public double UnitPrice { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("discount")]
        public double Discount { get; set; }
    }

    public class Order
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("customerId")]
        public string CustomerId { get; set; }

        [JsonPropertyName("employeeId")]
        public int EmployeeId { get; set; }

        [JsonPropertyName("orderDate")]
        public string OrderDate { get; set; }
        public DateTime OrderDateInDate { get; set; }

        [JsonPropertyName("requiredDate")]
        public string RequiredDate { get; set; }
        public DateTime RequiredDateInDate { get; set; }

        [JsonPropertyName("shippedDate")]
        public string ShippedDate { get; set; }
        public DateTime ShipDateInDate { get; set; }

        [JsonPropertyName("shipVia")]
        public int ShipVia { get; set; }

        [JsonPropertyName("freight")]
        public double Freight { get; set; }

        [JsonPropertyName("shipName")]
        public string ShipName { get; set; }

        [JsonPropertyName("shipAddress")]
        public ShipAddress ShipAddress { get; set; }

        [JsonPropertyName("details")]
        public List<Detail> Details { get; set; }
    }
}
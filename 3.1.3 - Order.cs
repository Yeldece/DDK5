using System;
namespace Console_review.Models
{
    class Order
    {
        public int id;
        public int customerId;
        public int employeeId;
        public DateTime orderDate;
        public DateTime requiredDate;
        public DateTime shippedDate;
        public int shipVia;
        public double freight;
        public string shipName;
    }
}
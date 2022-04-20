using System;
namespace VehicleProject
{
    public abstract class BaseVehicle
    {
        public int id { get; set; }
        public string brand { get; set; }
        //   public int Year { get; set; }
        protected virtual int CalculateTax(int year)
        {
            return year + 10;
        }

    }
}
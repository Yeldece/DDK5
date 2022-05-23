using System;
namespace VehicleProject
{
    public abstract class Vehicle
    {
        public int id { get; set; }
        //public Brand brand { get; set; }
        public int Year { get; set; }
        protected virtual int CalculateVisa(int year)
        {
            return year + 10;
        }
    }
}
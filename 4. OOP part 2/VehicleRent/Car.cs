using System;
namespace VehicleProject
{
    public class Car : Vehicle
    {
        public int VisaDate { get => base.CalculateVisa(Year); }

    }
}
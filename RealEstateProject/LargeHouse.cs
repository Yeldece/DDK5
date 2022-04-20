using System;
namespace RealEstateProject
{
    public class LargeHouse : House
    {
        public bool HasPool { get; set; }
        public int GardenArea { get; set; }
        public int GarageArea { get; set; }
        public LargeHouse(string location, int roomNumber) : base(location, roomNumber) { }
    }
}
using System;
namespace RealEstateProject
{
    public class House : RealEstate
    {
        public int RoomNumber { get; set; }
        public int Floors { get; set; }
        public bool Luxury { get; set; }
        public bool ParentBathroom { get => Luxury; }

        public House(string location, int roomNumber) : base(location)
        {
            RoomNumber = roomNumber;
        }
    }
}
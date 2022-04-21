using System;
namespace ClothShoping
{
    public class PrintManager
    {
        public void PrintBodySize(IClothSize cloth)
        {
            Console.WriteLine(cloth.BodySize);
        }
        public void PrintFabricType(IFabric cloth)
        {
            Console.WriteLine($"Your cloth has the {cloth.Type} type fabric.");
        }
    }
}
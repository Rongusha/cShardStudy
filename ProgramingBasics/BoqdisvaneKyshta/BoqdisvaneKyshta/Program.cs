using System;

namespace BoqdisvaneKyshta
{
    class Program
    {
        static void Main(string[] args)
        {
            double houseHaight = double.Parse(Console.ReadLine());
            double houseLenght = double.Parse(Console.ReadLine());
            double ceilingHaight = double.Parse(Console.ReadLine());

            double squareSide = (houseHaight * houseHaight) * 2;
            double doorSquareSide = 2 * 1.20;
            double paintForSquare = squareSide - doorSquareSide;

            double longSide = (houseHaight * houseLenght) * 2;
            double windowLongSide = (1.5 * 1.5) * 2;
            double paintForLong = longSide - windowLongSide;

            double roofSide = (houseHaight * houseLenght) * 2;
            double roofSmallSide = (houseHaight * ceilingHaight/2) * 2;

            double areaForSide = paintForLong + paintForSquare;
            double areaForRoof = roofSide + roofSmallSide;

            double paintForSide = areaForSide / 3.4;
            double paintForRoof = areaForRoof / 4.3;

            Console.WriteLine($"{paintForSide:f2}");
            Console.WriteLine($"{paintForRoof:f2}");


        }
    }
}

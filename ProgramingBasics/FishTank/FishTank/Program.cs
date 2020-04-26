using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //input aqariums L,W,H in cm
            //input % of space for sand and tools
            //1 litre of water = 10 cubic cm
            //calculate litres of water needed to fill the aquarium

            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double cubicCm = L * W * H;
            double ltrWater = cubicCm / 10;

            //to convert cubic cm to cubic dm            
            double ltrWaterDm = ltrWater * 0.01;

            //to convert percent in mathematical number
            double mathPercent = percent * 0.01;
            double totalLtrWater = ltrWaterDm - (mathPercent * ltrWaterDm);

            Console.WriteLine($"{totalLtrWater:f3}");



        }
    }
}

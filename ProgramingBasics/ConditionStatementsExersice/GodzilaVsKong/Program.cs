using System;

namespace GodzilaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());
            double priceForClothes = double.Parse(Console.ReadLine());

            double decore = budget * 0.10;
            

            if (employees > 150)
            {
                priceForClothes = priceForClothes * 0.90;
            }

            double moneyForClothes = employees * priceForClothes;
            double movieCost = moneyForClothes + decore;

            if ( movieCost > budget)
            {
                double moneyNeeded = movieCost - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }
            else
            {
                double moneyLeft = budget - movieCost;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }

        }
    }
}

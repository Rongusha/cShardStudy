using System;

namespace RibnaBorsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double macarelPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudsKg = double.Parse(Console.ReadLine());
            double safridusKg = double.Parse(Console.ReadLine());
            double midasKg = double.Parse(Console.ReadLine());

            double palamudsPrice = macarelPrice + (0.60 * macarelPrice);
            double safridusPrice = cacaPrice + (0.80 * cacaPrice);
            double midasPrice = 7.50;

            double palamudsTotalPrice = palamudsPrice * palamudsKg;
            double safridusTotalPrice = safridusKg * safridusPrice;
            double midasTotalPrice = midasKg * midasPrice;

            double totalMoneyNeeded = palamudsTotalPrice + safridusTotalPrice + midasTotalPrice;

            Console.WriteLine($"{totalMoneyNeeded:f2}");


        }
    }
}

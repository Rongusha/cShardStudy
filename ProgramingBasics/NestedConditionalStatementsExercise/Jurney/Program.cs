using System;

namespace Jurney
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    double moneySpent = budget * 0.30;
                    Console.WriteLine($"Camp - {moneySpent:f2}");
                }
                else if (season == "winter")
                {
                    double moneySpent = budget * 0.70;
                    Console.WriteLine($"Hotel - {moneySpent:f2}");
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    double moneySpent = budget * 0.40;
                    Console.WriteLine($"Camp - {moneySpent:f2}");
                }
                else if (season == "winter")
                {
                    double moneySpent = budget * 0.80;
                    Console.WriteLine($"Hotel - {moneySpent:f2}");
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
               
                    double moneySpent = budget * 0.90;
                    Console.WriteLine($"Hotel - {moneySpent:f2}");
                
            }
        }
    }
}

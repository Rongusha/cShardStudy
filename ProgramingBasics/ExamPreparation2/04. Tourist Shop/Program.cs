using System;

namespace _04._Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string command = "";
            double moneySpend = 0;
            int gearCounter = 0;

            while (moneySpend<=budget)
            {
                string gearType = Console.ReadLine();
                command = gearType;
                if (gearType == "Stop")
                {
                    break;
                }
                gearCounter++;
               
                double gearPrice = double.Parse(Console.ReadLine());
                if (gearCounter%3==0)
                {
                    gearPrice = gearPrice * 0.50;
                }
                moneySpend += gearPrice;


            }
            if (command=="Stop")
            {
                Console.WriteLine($"You bought {gearCounter} products for {moneySpend:f2} leva.");
            }
            else
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {moneySpend-budget:f2} leva!");
            }
        }
    }
}

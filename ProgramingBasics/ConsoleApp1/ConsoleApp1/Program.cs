using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int numPuzzles = int.Parse(Console.ReadLine());
            int numBarbies = int.Parse(Console.ReadLine());
            int numBears = int.Parse(Console.ReadLine());
            int numMinions = int.Parse(Console.ReadLine());
            int numTrucks = int.Parse(Console.ReadLine());
            int totalNumToys = numPuzzles + numBarbies + numBears + numMinions + numTrucks;



            double moneyFromPuzzles = numPuzzles * 2.60;
            double moneyFromBarbies = numBarbies * 3.00;
            double moneyFromBears = numBears * 4.10;
            double moneyFromMinions = numMinions * 8.20;
            double moneyFromTrucks = numTrucks * 2.00;
            double totalMoneyFromToys = moneyFromPuzzles + moneyFromBarbies + moneyFromBears + moneyFromMinions + moneyFromTrucks;

            
            if (totalNumToys >= 50)
            {
                totalMoneyFromToys = totalMoneyFromToys * 0.75;
                

            }
            totalMoneyFromToys = totalMoneyFromToys * 0.90;

           

                if (totalMoneyFromToys >= holidayPrice)
                {
                    Console.WriteLine($"Yes! {totalMoneyFromToys - holidayPrice:f2} lv left.");

                }
                else
                {
                    Console.WriteLine($"Not enough money! { holidayPrice- totalMoneyFromToys:f2} lv needed.");
                }
            
                
        }
    }
}

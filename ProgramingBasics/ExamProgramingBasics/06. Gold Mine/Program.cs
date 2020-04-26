using System;

namespace _06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLocations = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numLocations; i++)
            {
                double expectedProfit = double.Parse(Console.ReadLine());//average per day
                int numDays = int.Parse(Console.ReadLine());//per location


                double profitSum = 0;
                for (int day = 1; day <= numDays; day++)
                {
                    double profit = double.Parse(Console.ReadLine());//real profit per day
                    profitSum += profit;
                }
                if ((profitSum/numDays)>=expectedProfit)
                {
                    Console.WriteLine($"Good job! Average gold per day: {profitSum/numDays:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {expectedProfit - (profitSum/numDays):f2} gold.");
                }
            }
        }
    }
}

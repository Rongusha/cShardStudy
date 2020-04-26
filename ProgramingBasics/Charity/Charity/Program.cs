using System;

namespace Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            //input numbers of days, numbers of chefs, number of cakes, pancakes, gufrets
            //cake is 45 Bng , pancake is 3.20 Bng, gufret is 5.80 Bgn
            //1/8 of raised money will cover expences
            //calculate num of cakes made from 1 chef for 1 day 
            //calculate how much money will be left at the end for charity

            int numDays = int.Parse(Console.ReadLine());
            int numChefs = int.Parse(Console.ReadLine());
            int numCakes = int.Parse(Console.ReadLine());
            int numGufrets = int.Parse(Console.ReadLine());
            int numPancakes = int.Parse(Console.ReadLine());
            

            double dayPriceCake = numCakes * 45.00;
            double dayPriceGufrets = numGufrets * 5.80;
            double dayPricePancakes = numPancakes * 3.20;
            

            double totalDaySum = (dayPriceCake + dayPriceGufrets + dayPricePancakes) * numChefs;
            double eventSum = totalDaySum * numDays;

            double oneEight = eventSum / 8;
            double raisedMoney = eventSum - oneEight;

            
            Console.WriteLine($"{raisedMoney:f2}");


        }
    }
}

using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            int foodKg = int.Parse(Console.ReadLine());
            double dailyFoodDog = double.Parse(Console.ReadLine());
            double dailyFoodCat = double.Parse(Console.ReadLine());
            double dailyFoodTurtle = double.Parse(Console.ReadLine());
            //Turtle food is in grams

            double allFoodDog = dailyFoodDog * numDays;
            double allFoodCat = dailyFoodCat * numDays;
            double allFoodTurtle = (dailyFoodTurtle / 1000) * numDays;
            double allFoodNeeded = allFoodCat + allFoodDog + allFoodTurtle;

            if (foodKg >= allFoodNeeded)
            {
                double difference = foodKg - allFoodNeeded;
                Console.WriteLine($"{Math.Floor (difference)} kilos of food left.");
            }
            else
            {
                double difference = allFoodNeeded - foodKg;
                Console.WriteLine($"{Math.Ceiling (difference)} more kilos of food are needed.");
            }

        }
    }
}

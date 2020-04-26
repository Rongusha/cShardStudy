using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int landSize = int.Parse(Console.ReadLine());
            double grapesFromSquare = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int numOfWorkers = int.Parse(Console.ReadLine());
            // 40% of grapes goes for wine
            // 1 ltr wine need 2.5 kg grapes

            double allGrapes = landSize * grapesFromSquare;
            double grapesForWine = allGrapes * 0.40;
            double litresOfWine = (grapesForWine / 2.5);

            if (litresOfWine >= wineNeeded)
            {
               double difference = Math.Ceiling (litresOfWine - wineNeeded);
                double litresPerWorker = Math.Ceiling (difference / numOfWorkers);
                Console.WriteLine($"Good harvest this year! Total wine: { Math.Floor (litresOfWine)} liters.");
                Console.WriteLine($"{difference} liters left -> {litresPerWorker} liters per person.");

            }
            else
            {
                double difference =Math.Floor (wineNeeded - litresOfWine);
                Console.WriteLine($"It will be a tough winter! More {difference} liters wine needed.");

            }

        }
    }
}

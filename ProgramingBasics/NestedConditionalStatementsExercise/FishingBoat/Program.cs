using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numFishers = int.Parse(Console.ReadLine());

            double costOfBoat = 0;

            if (season == "Spring")
            {
                costOfBoat = 3000;

                if (numFishers <= 6)
                {
                    costOfBoat = costOfBoat * 0.90;
                }
                else if (numFishers >= 7 && numFishers <= 11)
                {
                    costOfBoat = costOfBoat * 0.85;
                }
                else if (numFishers >= 12)
                {
                    costOfBoat = costOfBoat * 0.75;
                }
                if (numFishers % 2 == 0)
                {
                    costOfBoat = costOfBoat * 0.95;
                }
                if (budget >= costOfBoat)
                {
                    double difference = budget - costOfBoat;
                    Console.WriteLine($"Yes! You have {difference:f2} leva left.");
                }
                else if (budget < costOfBoat)
                {
                    double difference = costOfBoat - budget;
                    Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
                }
            }
            else if (season == "Summer")
            {
                costOfBoat = 4200;

                if (numFishers <= 6)
                {
                    costOfBoat = costOfBoat * 0.90;
                }
                else if (numFishers >= 7 && numFishers <= 11)
                {
                    costOfBoat = costOfBoat * 0.85;
                }
                else if (numFishers >= 12)
                {
                    costOfBoat = costOfBoat * 0.75;
                }
                if (numFishers % 2 == 0)
                {
                    costOfBoat = costOfBoat * 0.95;
                }
                if (budget >= costOfBoat)
                {
                    double difference = budget - costOfBoat;
                    Console.WriteLine($"Yes! You have {difference:f2} leva left.");
                }
                else if (budget < costOfBoat)
                {
                    double difference = costOfBoat - budget;
                    Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
                }
            }
            else if (season == "Autumn")
            {
                costOfBoat = 4200;

                if (numFishers <= 6)
                {
                    costOfBoat = costOfBoat * 0.90;
                }
                else if (numFishers >= 7 && numFishers <= 11)
                {
                    costOfBoat = costOfBoat * 0.85;
                }
                else if (numFishers >= 12)
                {
                    costOfBoat = costOfBoat * 0.75;
                }
                if (budget >= costOfBoat)
                {
                    double difference = budget - costOfBoat;
                    Console.WriteLine($"Yes! You have {difference:f2} leva left.");
                }
                else if (budget < costOfBoat)
                {
                    double difference = costOfBoat - budget;
                    Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
                }
            }
            else if (season == "Winter")
            {
                costOfBoat = 2600;

                if (numFishers <= 6)
                {
                    costOfBoat = costOfBoat * 0.90;
                }
                else if (numFishers >= 7 && numFishers <= 11)
                {
                    costOfBoat = costOfBoat * 0.85;
                }
                else if (numFishers >= 12)
                {
                    costOfBoat = costOfBoat * 0.75;
                }
                if (numFishers % 2 == 0)
                {
                    costOfBoat = costOfBoat * 0.95;
                }
                if (budget >= costOfBoat)
                {
                    double difference = budget - costOfBoat;
                    Console.WriteLine($"Yes! You have {difference:f2} leva left.");
                }
                else if (budget < costOfBoat)
                {
                    double difference = costOfBoat - budget;
                    Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
                }
            }
        }
    }
}

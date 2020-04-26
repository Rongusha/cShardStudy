using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Roses - 5 lv
            //Dahlias - 3.80 lv
            //Tulips - 2.80 lv
            //Narcissus - 3 lv
            //Gladiolus - 2.50

            string flowerType = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double flowerPrice = 0;

            if (flowerType == "Roses")
            {
                flowerPrice = 5;
                double setPrice = flowerPrice * numFlowers;
                if (numFlowers > 80)
                {
                    setPrice = setPrice * 0.90;
                }
                if (setPrice > budget)
                {
                    double difference = setPrice - budget;
                    Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                }
                else if (setPrice <= budget)
                {
                    double difference = budget - setPrice;
                    Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flowerType} and {difference:f2} leva left.");

                }

            }
            else if (flowerType == "Dahlias")
            {
                flowerPrice = 3.80;
                double setPrice = flowerPrice * numFlowers;
                if (numFlowers > 90)
                {
                    setPrice = setPrice * 0.85;
                }
                if (setPrice > budget)
                {
                    double difference = setPrice - budget;
                    Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                }
                else if (setPrice <= budget)
                {
                    double difference = budget - setPrice;
                    Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flowerType} and {difference:f2} leva left.");

                }
            }
            else if (flowerType == "Tulips")
            {
                flowerPrice = 2.80;
                double setPrice = flowerPrice * numFlowers;
                if (numFlowers > 80)
                {
                    setPrice = setPrice * 0.85;
                }
                if (setPrice > budget)
                {
                    double difference = setPrice - budget;
                    Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                }
                else if (setPrice <= budget)
                {
                    double difference = budget - setPrice;
                    Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flowerType} and {difference:f2} leva left.");

                }
            }
            else if (flowerType == "Narcissus")
            {
                flowerPrice = 3.00;
                double setPrice = flowerPrice * numFlowers;
                if (numFlowers < 120)
                {
                    setPrice = setPrice * 1.15;
                }
                if (setPrice > budget)
                {
                    double difference = setPrice - budget;
                    Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                }
                else if (setPrice <= budget)
                {
                    double difference = budget - setPrice;
                    Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flowerType} and {difference:f2} leva left.");

                }
            }
            else if (flowerType == "Gladiolus")
            {
                flowerPrice = 2.50;
                double setPrice = flowerPrice * numFlowers;
                if (numFlowers < 80)
                {
                    setPrice = setPrice * 1.20;
                }
                if (setPrice > budget)
                {
                    double difference = setPrice - budget;
                    Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                }
                else if (setPrice <= budget)
                {
                    double difference = budget - setPrice;
                    Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flowerType} and {difference:f2} leva left.");

                }
            }

        }
    }
}

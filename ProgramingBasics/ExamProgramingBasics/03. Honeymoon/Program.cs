using System;

namespace _03._Honeymoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string city = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double pricePerNight = 0;//per person(we have 2)
            double flightsPrice = 0;//bothways for both
            double endPrice = (pricePerNight * nights) + flightsPrice;
            if (city == "Cairo")
            {
                pricePerNight = 250 * 2;
                flightsPrice = 600;
                endPrice = (pricePerNight * nights) + flightsPrice;

                if (nights > 0 && nights < 5)
                {
                    endPrice = endPrice * 0.97;
                }
                else if (nights >= 5 && nights <= 9)
                {
                    endPrice = endPrice * 0.95;
                }
                else if (nights >= 10 && nights <= 24)
                {
                    endPrice = endPrice * 0.90;
                }
                else if (nights >= 25 && nights <= 49)
                {
                    endPrice = endPrice * 0.83;
                }
                else if (nights >= 50)
                {
                    endPrice = endPrice * 0.70;
                }
            }
            else if (city == "Paris")
            {
                pricePerNight = 150 * 2;
                flightsPrice = 350;
                endPrice = (pricePerNight * nights) + flightsPrice;

                if (nights >= 5 && nights <= 9)
                {
                    endPrice = endPrice * 0.93;
                }
                else if (nights >= 10 && nights <= 24)
                {
                    endPrice = endPrice * 0.88;
                }
                else if (nights >= 25 && nights <= 49)
                {
                    endPrice = endPrice * 0.78;
                }
                else if (nights >= 50)
                {
                    endPrice = endPrice * 0.70;
                }
            }
            else if (city == "Lima")
            {
                pricePerNight = 400 * 2;
                flightsPrice = 850;
                endPrice = (pricePerNight * nights) + flightsPrice;

                if (nights >= 25 && nights <= 49)
                {
                    endPrice = endPrice * 0.81;
                }
                else if (nights >= 50)
                {
                    endPrice = endPrice * 0.70;
                }
            }
            else if (city == "New York")
            {
                pricePerNight = 300 * 2;
                flightsPrice = 650;
                endPrice = (pricePerNight * nights) + flightsPrice;

                if (nights > 0 && nights < 5)
                {
                    endPrice = endPrice * 0.97;
                }
                else if (nights >= 5 && nights <= 9)
                {
                    endPrice = endPrice * 0.95;
                }
                else if (nights >= 10 && nights <= 24)
                {
                    endPrice = endPrice * 0.88;
                }
                else if (nights >= 25 && nights <= 49)
                {
                    endPrice = endPrice * 0.81;
                }
                else if (nights >= 50)
                {
                    endPrice = endPrice * 0.70;
                }
            }
            else if (city == "Tokyo")
            {
                pricePerNight = 350 * 2;
                flightsPrice = 700;
                endPrice = (pricePerNight * nights) + flightsPrice;

                if (nights >= 10 && nights <= 24)
                {
                    endPrice = endPrice * 0.88;
                }
                else if (nights >= 25 && nights <= 49)
                {
                    endPrice = endPrice * 0.83;
                }
                else if (nights >= 50)
                {
                    endPrice = endPrice * 0.70;
                }
            }

            if (budget>=endPrice)
            {
                Console.WriteLine($"Yes! You have {budget-endPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {endPrice-budget:f2} leva.");
            }
        }
    }
}

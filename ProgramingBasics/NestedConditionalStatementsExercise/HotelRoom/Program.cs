using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            if (month == "May"|| month=="October")
            {
                double studioPrice = 50;
                double appartmentPrice = 65;
                if (nights > 7 && nights <= 14)
                {
                    studioPrice = studioPrice * 0.95;
                }
                else if (nights > 14)
                {
                    studioPrice = studioPrice * 0.70;
                    appartmentPrice = appartmentPrice * 0.90;
                }
                double sumPriceAppartment = appartmentPrice * nights;
                double sumPriceStudio = studioPrice * nights;
                Console.WriteLine($"Apartment: {sumPriceAppartment:f2} lv.");
                Console.WriteLine($"Studio: {sumPriceStudio:f2} lv.");
            }
            else if (month == "June" || month == "September")
            {
                double studioPrice = 75.20;
                double appartmentPrice = 68.70;
                if (nights > 14)
                {
                    studioPrice = studioPrice * 0.80;
                    appartmentPrice = appartmentPrice * 0.90;
                }
                double sumPrice = appartmentPrice * nights;
                double sumPriceStudio = studioPrice * nights;
                Console.WriteLine($"Apartment: {sumPrice:f2} lv.");
                Console.WriteLine($"Studio: {sumPriceStudio:f2} lv.");
            }
            else if (month == "July" || month == "August")
            {
                double studioPrice = 76;
                double appartmentPrice = 77;
                
                if (nights > 14)
                {
                    appartmentPrice = appartmentPrice * 0.90;
                }
                double sumPrice = appartmentPrice * nights;
                double sumPriceStudio = studioPrice * nights;
                Console.WriteLine($"Apartment: {sumPrice:f2} lv.");
                Console.WriteLine($"Studio: {sumPriceStudio:f2} lv.");
            }
        }
    }
}

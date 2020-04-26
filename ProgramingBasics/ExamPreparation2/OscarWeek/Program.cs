using System;

namespace OscarWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie =Console.ReadLine();
            string cinema = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double ticketPrice = 0;
            if (movie=="A Star Is Born")
            {
                if (cinema == "normal")
                {
                    ticketPrice = 7.50;
                }
                else if (cinema== "luxury")
                {
                    ticketPrice = 10.50;
                }
                else if (cinema== "ultra luxury")
                {
                    ticketPrice = 13.50;
                }
            }
            else if (movie=="Bohemian Rhapsody")
            {
                if (cinema == "normal")
                {
                    ticketPrice = 7.35;
                }
                else if (cinema == "luxury")
                {
                    ticketPrice = 9.45;
                }
                else if (cinema == "ultra luxury")
                {
                    ticketPrice = 12.75;
                }

            }
            else if (movie== "Green Book")
            {
                if (cinema == "normal")
                {
                    ticketPrice = 8.15;
                }
                else if (cinema == "luxury")
                {
                    ticketPrice = 10.25;
                }
                else if (cinema == "ultra luxury")
                {
                    ticketPrice = 13.25;
                }
            }
            else if (movie== "The Favourite")
            {
                if (cinema == "normal")
                {
                    ticketPrice = 8.75;
                }
                else if (cinema == "luxury")
                {
                    ticketPrice = 11.55;
                }
                else if (cinema == "ultra luxury")
                {
                    ticketPrice = 13.95;
                }
            }

            double moneyMade = tickets * ticketPrice;
            Console.WriteLine($"{movie} -> {moneyMade:f2} lv.");
        }
    }
}

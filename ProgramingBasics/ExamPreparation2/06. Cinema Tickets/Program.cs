using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            double ticketCount = 0;
            double studenCount = 0;
            double standardCount = 0;
            double kidCount = 0;
            double totalTickets = 0;

            while (movie != "Finish")
            {
                double freeSpots = double.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();
                while (ticketType!="End")
                {
                    
                    if (ticketType== "student")
                    {
                        studenCount++;
                        ticketCount++;
                        totalTickets++;
                    }
                    else if (ticketType== "standard")
                    {
                        standardCount++;
                        ticketCount++;
                        totalTickets++;
                    }
                    else if (ticketType== "kid")
                    {
                        kidCount++;
                        ticketCount++;
                        totalTickets++;
                    }
                   
                    if (ticketCount>=freeSpots)
                    {
                        break;
                    }
                    ticketType =Console.ReadLine();
                }

                Console.WriteLine($"{movie} - {ticketCount/freeSpots *100:f2}% full.");
                ticketCount = 0;

                movie =Console.ReadLine();

            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studenCount/ totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standardCount/ totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidCount/ totalTickets * 100:f2}% kids tickets.");
        }
    }
}

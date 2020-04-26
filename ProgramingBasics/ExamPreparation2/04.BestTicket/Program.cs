using System;

namespace _04.BestTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine();

            double bestPrice = 0;
            string bestTicket = "";
            int shortestStay = int.MaxValue;

            while (ticket != "End")
            {

                double ticketPrice = double.Parse(Console.ReadLine());
                int minuteStay = int.Parse(Console.ReadLine());

                if (minuteStay < shortestStay)
                {
                    shortestStay = minuteStay;
                    bestTicket = ticket;
                    bestPrice = ticketPrice;
                }

                ticket = Console.ReadLine();
            }
            if (shortestStay != int.MaxValue)
            {
                Console.WriteLine($"Ticket found for flight {bestTicket} costs {(bestPrice * 1.96):f2} leva with {shortestStay / 60}h {shortestStay % 60}m stay");
            }

        }
    }
}

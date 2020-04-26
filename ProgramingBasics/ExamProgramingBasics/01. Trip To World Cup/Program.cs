using System;

namespace _01._Trip_To_World_Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            double goingTicket = double.Parse(Console.ReadLine());
            double returnTicket = double.Parse(Console.ReadLine());
            double matchPrice = double.Parse(Console.ReadLine());
            int matchCount = int.Parse(Console.ReadLine());
            double discountPercent = double.Parse(Console.ReadLine());

            double ticketSum = ((matchPrice * matchCount) * 6);
            double flightSum = ((goingTicket + returnTicket) * 6);
            double sumAfterDiscount = flightSum - (flightSum / 100 * discountPercent);
            double tripCost = ticketSum + sumAfterDiscount;
            double priceForEach = tripCost / 6;

            Console.WriteLine($"Total sum: {tripCost:f2} lv.");
            Console.WriteLine($"Each friend has to pay {priceForEach:f2} lv.");

        }
    }
}

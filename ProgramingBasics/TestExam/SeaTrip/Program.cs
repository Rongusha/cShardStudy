using System;

namespace SeaTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodMoney = double.Parse(Console.ReadLine());//for 1 day
            double presentsMoney = double.Parse(Console.ReadLine());// for 1 day
            double hotelMoney = double.Parse(Console.ReadLine());//for 1 day

            double hotelPriceDay1 = hotelMoney * 0.90;
            double hotelPriceDay2 = hotelMoney * 0.85;
            double hotelPriceDay3 = hotelMoney * 0.80;
            double totalHotelPrice = hotelPriceDay1 + hotelPriceDay2 + hotelPriceDay3;

            double totalFoodPrice = foodMoney * 3;
            double totalPresentsPrice = presentsMoney * 3;
            double FuelPrice = ((420.0 / 100.0)*7.0) * 1.85;

            double totalMoneyNeeded = FuelPrice + totalFoodPrice + totalHotelPrice + totalPresentsPrice;
            Console.WriteLine($"Money needed: {totalMoneyNeeded:f2}");
        }
    }
}

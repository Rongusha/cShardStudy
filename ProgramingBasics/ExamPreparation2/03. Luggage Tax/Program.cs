using System;

namespace _03._Luggage_Tax
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double statuePrice = rent * 0.70;
            double foodPrice = statuePrice * 0.85;
            double musicPrice = foodPrice / 2.0;

            double totalPrice = rent + statuePrice + foodPrice + musicPrice;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}

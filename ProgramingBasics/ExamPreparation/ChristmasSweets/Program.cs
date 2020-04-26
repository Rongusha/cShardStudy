using System;

namespace ChristmasSweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double cackePrice = double.Parse(Console.ReadLine());
            double muffinPrice = double.Parse(Console.ReadLine());
            double shtolenWeight = double.Parse(Console.ReadLine());
            double sweetsWeight = double.Parse(Console.ReadLine());
            double biscuitsWeight = double.Parse(Console.ReadLine());

            double shtolenPrice = cackePrice * 1.60;
            double sweetsPrice = muffinPrice * 1.80;
            double biscuitsPrice = 7.50;

            double shtolenTotalPrice = shtolenPrice * shtolenWeight;
            double sweetsTotalPrice = sweetsPrice * sweetsWeight;
            double biscuitsTotalPrice = biscuitsPrice * biscuitsWeight;

            double totalTotalPrice = shtolenTotalPrice + sweetsTotalPrice + biscuitsTotalPrice;

            Console.WriteLine($"{totalTotalPrice:f2}");
            
        }
    }
}

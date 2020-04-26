using System;

namespace _01._Lemonade_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            double lemons = double.Parse(Console.ReadLine());//980ml from 1
            double sugar = double.Parse(Console.ReadLine());//980ml + 30% from shugar
            double water = double.Parse(Console.ReadLine());
            //1.20 for a cup of 150ml

            double totalJuse = (lemons * 980) + (water * 1000) + (sugar * 0.30);
            double cups = Math.Floor(totalJuse / 150);
            double moneyMade = cups * 1.20;
            Console.WriteLine($"All cups sold: {cups}");
            Console.WriteLine($"Money earned: {moneyMade:f2}");
        }
    }
}

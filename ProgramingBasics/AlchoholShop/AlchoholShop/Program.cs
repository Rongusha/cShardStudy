using System;

namespace AlchoholShop
{
    class Program
    {
        static void Main(string[] args)
        {

            double priceWiskey = double.Parse(Console.ReadLine());
            double ltrBeer = double.Parse(Console.ReadLine());
            double ltrWine = double.Parse(Console.ReadLine());
            double ltrRaki = double.Parse(Console.ReadLine());
            double ltrWiskey = double.Parse(Console.ReadLine());

            double priceRaki = (priceWiskey / 2);
            double priceWine = (priceRaki - (0.4 * priceRaki));
            double priceBeer = (priceRaki - (0.8 * priceRaki));
            double totalPriceWiskey = priceWiskey * ltrWiskey;
            double totalPriceRaki = priceRaki * ltrRaki;
            double totalPriceWine = priceWine * ltrWine;
            double totalPriceBeer = priceBeer * ltrBeer;

            double totalPrice = totalPriceWiskey + totalPriceRaki + totalPriceWine + totalPriceBeer;

          
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}

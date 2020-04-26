using System;

namespace ZelenchukovShop
{
    class Program
    {
        static void Main(string[] args)
        {

            double vegiePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegieKg = double.Parse(Console.ReadLine());
            double fruidKg = double.Parse(Console.ReadLine());

            double totalPrice = (vegiePrice * vegieKg) + (fruitPrice * fruidKg);
            double priceEuro = totalPrice / 1.94;

            Console.WriteLine($"{priceEuro:f2}");


        }
    }
}

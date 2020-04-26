using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int others = int.Parse(Console.ReadLine());

            double priceDogFood = 2.50;
            double priceOthesFood = 4.00;

            double totalPrice = (dogs * priceDogFood) + (others * priceOthesFood);

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}

using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            CalculateCost(product, quantity);
        }

        static void CalculateCost(string product, int quantity)
        {
            double price = 0;
            if (product == "coffee")
            {
                price = 1.50;
            }

            else if (product == "water")
            {
                price = 1.00;
            }

            else if (product == "coke")
            {
                price = 1.40;
            }

            else if (product == "snacks")
            {
                price = 2.00;
            }

            Console.WriteLine($"{quantity * price:f2}");
        }

    }
}

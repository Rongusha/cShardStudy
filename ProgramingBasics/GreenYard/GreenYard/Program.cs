using System;

namespace GreenYard
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareM = double.Parse(Console.ReadLine());
            double pricePerM = 7.61;
            double totalPrice = squareM * pricePerM;
            double discount = 0.18 * totalPrice;
            double totalDicPrice = totalPrice - discount;



            Console.WriteLine($"The final price is: {totalDicPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");


        }
    }
}

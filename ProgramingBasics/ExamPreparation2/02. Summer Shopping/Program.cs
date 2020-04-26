using System;

namespace _02._Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double towelPrice = double.Parse(Console.ReadLine());
            double discountPercent = double.Parse(Console.ReadLine());

            double umbrelaPrice = (towelPrice / 3.0) * 2;
            double flipFlopsPrice = umbrelaPrice * 0.75;
            double bagPrice = (towelPrice + flipFlopsPrice) / 3.0;

            double sum = umbrelaPrice + flipFlopsPrice + bagPrice + towelPrice;
            double totalSum =sum- (sum/100*discountPercent);

            if (budget>=totalSum)
            {
                Console.WriteLine($"Annie's sum is {totalSum:f2} lv. She has {budget-totalSum:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {totalSum:f2} lv. She needs {totalSum-budget:f2} lv. more.");
            }


        }
    }
}

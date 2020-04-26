using System;

namespace GodzilaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;

            if (employees>150)
            {
                clothes = clothes * 0.90;
            }
            double moneyNeeded = decor + (employees * clothes);
            if (budget>=moneyNeeded)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-moneyNeeded:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded-budget:f2} leva more.");
            }
        }
    }
}

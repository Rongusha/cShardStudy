using System;

namespace _01._Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double wages = double.Parse(Console.ReadLine());
            int monthsToSave = int.Parse(Console.ReadLine());
            double bills = double.Parse(Console.ReadLine());

            double buffer = wages * 0.70;
            double moneyleft = buffer - bills;

            double savedMoney = moneyleft / wages *100;
            double totalSaved = moneyleft * monthsToSave;

            Console.WriteLine($"She can save {savedMoney:f2}%");
            Console.WriteLine($"{totalSaved:f2}");
        }
    }
}

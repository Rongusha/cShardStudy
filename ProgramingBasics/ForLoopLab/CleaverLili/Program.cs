using System;

namespace CleaverLili
{
    class Program
    {
        static void Main(string[] args)
        {
            int liliAge = int.Parse(Console.ReadLine());
            double machinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            //second birday 9lv every second +9lv
            // sold the toys for extra savings

            int moneyCounter = 0;
            int savedMoney = 0;
            int toysCounter = 0;
            int brotherMoney = 0;


            for (int i = 1; i <= liliAge; i++)
            {
                if (i % 2 == 0)
                {
                    moneyCounter += 10;
                    savedMoney += moneyCounter;
                    brotherMoney++;

                }
                else
                {
                    toysCounter++;
                }
            }
            double moneyFromToys = toysCounter * toyPrice;

            double totalMoney = (moneyFromToys + savedMoney) - brotherMoney;
            if (machinePrice <= totalMoney)
            {
                Console.WriteLine($"Yes! {totalMoney - machinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {machinePrice - totalMoney:f2}");
            }

        }
    }
}

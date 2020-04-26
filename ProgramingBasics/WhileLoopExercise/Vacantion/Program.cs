using System;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForTrip = double.Parse(Console.ReadLine());
            double moneyHave = double.Parse(Console.ReadLine());
            

            int daysCounter = 0;
            int spendCounter = 0;


            while (moneyForTrip > moneyHave && spendCounter <5)
            {
               string command = Console.ReadLine();
              double  money = double.Parse(Console.ReadLine());
                daysCounter++;

                if (command == "save")
                {
                    moneyHave += money;
                    spendCounter = 0;
                }
                else if (command == "spend")
                {
                    moneyHave -= money;
                    spendCounter++;
                    
                    if (moneyHave < 0)
                    {
                        moneyHave = 0;
                    }
                }
            }
            if (spendCounter >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysCounter}");
            }
            if (moneyHave >= moneyForTrip)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}

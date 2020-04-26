using System;

namespace ChristmasDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double moneyLeft = budget;
            double sum = 0;
            string command = "";

            while (sum < budget)
            {
                command = Console.ReadLine();
                if (command == "Stop")
                {
                    Console.WriteLine($"Money left: {moneyLeft}");
                    return;
                }
                sum = 0;
                for (int i = 0; i < command.Length; i++)
                {

                    char digit = command[i];
                    int digitToNum = (int)digit;
                    sum += digitToNum;
                    
                }
                if (sum <= moneyLeft)
                {
                    Console.WriteLine("Item successfully purchased!");
                    moneyLeft -= sum;
                }
                else if (sum > moneyLeft)
                {
                    Console.WriteLine("Not enough money!");
                    return;
                }
                
            }

           
        }
    }
}

using System;

namespace Фисхинг
{
    class Program
    {
        static void Main(string[] args)
        {
            int fishAllowed = int.Parse(Console.ReadLine());

            int fishNumbers = 0;
            string command = "";
            double spending = 0;
            double profit = 0;

            while (fishNumbers < fishAllowed )
            {
                command = Console.ReadLine();
                if (command == "Stop")
                {
                    
                    break;
                }

                double fishWheit = double.Parse(Console.ReadLine());
                fishNumbers++;

                int charSum = 0;
                for (int i = 0; i < command.Length; i++)
                {
                    char current = command[i];
                    int currentNum = (int)current;
                    charSum += currentNum;
                }

                double fishPrice = charSum / fishWheit;

                if (fishNumbers % 3 == 0)
                {
                    profit += fishPrice;
                }
                else
                {
                    spending += fishPrice;
                }
            }
            if (fishNumbers >= fishAllowed)
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
            }
            if (profit>=spending)
            {
                Console.WriteLine($"Lyubo's profit from {fishNumbers} fishes is {profit - spending:f2} leva.");
            }
            else
            {
                Console.WriteLine($"Lyubo lost {spending - profit:f2} leva today.");
            }
        }
    }
}

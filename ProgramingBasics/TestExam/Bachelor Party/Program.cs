using System;

namespace Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget =double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double cuvert = 0;
            double savings = 0;
            int allPplNum = 0;

            while (command!= "The restaurant is full")
            {
                
                int pplNum = int.Parse(command);
               
                allPplNum += pplNum;
                if (command == "The restaurant is full")
                {
                    break;
                }
                if (pplNum < 5)
                {
                    cuvert = 100 * pplNum;
                    savings += cuvert;
                }
                else if (pplNum >=5)
                {
                    cuvert = 70 * pplNum;
                    savings += cuvert;
                }

                command = Console.ReadLine();
            }
            if (savings >= budget)
            {
                Console.WriteLine($"You have {allPplNum} guests and {savings-budget} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {allPplNum} guests and {savings} leva income, but no singer.");
            }
        }
    }
}

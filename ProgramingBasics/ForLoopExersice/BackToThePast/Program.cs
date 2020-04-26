using System;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyOwe = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());

            double evenCounter = 0; // need 12k to live
            double oddCounter = 0; // need 12k + (50 * buyYears) to live

            int boyYears = 18;
           

            for (int i = 1800; i <= yearToLive; i++)
            {

                

                if (i %2 == 0)
                {
                    evenCounter++;
                    moneyOwe -= 12000;
                    
                }
                else
                {
                    oddCounter++;
                    moneyOwe -= 12000 + 50 * boyYears;
                    
                    
                }

                boyYears++;
            }

           

            if (moneyOwe >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyOwe:f2} dollars left.");

            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(moneyOwe - 0):f2} dollars to survive.");
            }
        }
    }
}

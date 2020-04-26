using System;

namespace Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiType = Console.ReadLine();
            string reustorant = Console.ReadLine();
            int numPlates = int.Parse(Console.ReadLine());
            char forHome = char.Parse(Console.ReadLine());

            double sashimiPrice = 0;
            double makiPrice = 0;
            double uramakiPrice = 0;
            double temakiPrice = 0;
            if (sushiType == "sashimi")
            {
                if (reustorant == "Sushi Zone")
                {
                    sashimiPrice = 4.99;
                }
                else if (reustorant == "Sushi Time")
                {
                    sashimiPrice = 5.49;
                }
                else if (reustorant == "Sushi Bar")
                {
                    sashimiPrice = 5.25;
                }
                else if (reustorant == "Asian Pub")
                {
                    sashimiPrice = 4.50;
                }
                else
                {
                    Console.WriteLine($"{reustorant} is invalid restaurant!");
                    return;
                }
            }
            else if (sushiType == "maki")
            {
                if (reustorant == "Sushi Zone")
                {
                    makiPrice = 5.29;
                }
                else if (reustorant == "Sushi Time")
                {
                    makiPrice = 4.69;
                }
                else if (reustorant == "Sushi Bar")
                {
                    makiPrice = 5.55;
                }
                else if (reustorant == "Asian Pub")
                {
                    makiPrice = 4.80;
                }
                else
                {
                    Console.WriteLine($"{reustorant} is invalid restaurant!");
                    return;
                }
            }
            else if (sushiType == "uramaki")
            {
                if (reustorant == "Sushi Zone")
                {
                    uramakiPrice = 5.99;
                }
                else if (reustorant == "Sushi Time")
                {
                    uramakiPrice = 4.49;
                }
                else if (reustorant == "Sushi Bar")
                {
                    uramakiPrice = 6.25;
                }
                else if (reustorant == "Asian Pub")
                {
                    uramakiPrice = 5.50;
                }
                else
                {
                    Console.WriteLine($"{reustorant} is invalid restaurant!");
                    return;
                }
            }
            else if (sushiType == "temaki")
            {
                if (reustorant == "Sushi Zone")
                {
                    temakiPrice = 4.29;
                }
                else if (reustorant == "Sushi Time")
                {
                    temakiPrice = 5.19;
                }
                else if (reustorant == "Sushi Bar")
                {
                    temakiPrice = 4.75;
                }
                else if (reustorant == "Asian Pub")
                {
                    temakiPrice = 5.50;
                }
                else
                {
                    Console.WriteLine($"{reustorant} is invalid restaurant!");
                    return;
                }
            }
            double sum = (sashimiPrice + makiPrice + uramakiPrice + temakiPrice)*numPlates;
            if (forHome == 'Y')
            {
                sum = sum * 1.20;
            }
            else
            {
                sum = sum + 0;
            }
            Console.WriteLine($"Total price: {Math.Ceiling(sum)} lv.");
        }
    }
}

using System;

namespace Humore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type of Fart: ");
            string typeOfFart = Console.ReadLine();
            

            if (typeOfFart == "silent")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("YOU ARE IN DANGER!!! Silent death is aproaching with deadly smell! RUN FOREST, RUN!!!");
                Console.ResetColor();
            }
            else if (typeOfFart == "loud")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU ARE SAFE!!! Loud farts are like loud people, they are not a danger for you!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Thats not a type of fart you id..t, dont make yourself to me you small village stick, my light house hurts me for you!!! AAAmaha boy , I will f.ck your numbers!");
            }
        }
    }
}

using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            string cakePeaces = Console.ReadLine();

            int cakeArea = lenght * width;
            int PeaceCounter = 0;

            while (cakePeaces != "STOP")
            {
                PeaceCounter += int.Parse(cakePeaces);

                if (PeaceCounter > cakeArea)
                {
                    Console.WriteLine($"No more cake left! You need { Math.Abs(cakeArea - PeaceCounter)} pieces more.");
                    break;
                }
                cakePeaces = Console.ReadLine();

            }


            if (PeaceCounter <= cakeArea)
            {
                Console.WriteLine($"{Math.Abs(PeaceCounter - cakeArea)} pieces are left.");
            }



        }
    }
}

using System;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double averageH = double.Parse(Console.ReadLine());

            double roomSpace = 2.0 * 2.0 * (averageH + 0.40);
            double shipSpace = w * l * h;
            double pplCount = Math.Floor(shipSpace / roomSpace);

            if (pplCount < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (pplCount >= 3 && pplCount <= 10)
            {
                Console.WriteLine($"The spacecraft holds {pplCount} astronauts.");
            }
            else 
            {
                Console.WriteLine("The spacecraft is too big.");
            }

        }
    }
}

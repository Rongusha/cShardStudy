using System;

namespace UchebnaZala
{
    class Program
    {
        static void Main(string[] args)
        {

            double L = double.Parse(Console.ReadLine()) * 100;
            double W = double.Parse(Console.ReadLine()) * 100;
            int hallway = 100;

            double realW = W - hallway;
            double numRollsW = Math.Floor(realW / 70);
            double numRollsL = Math.Floor(L / 120);
            double totalDesk = numRollsL * numRollsW;
            double realTotalDesk = totalDesk - 3;

            Console.WriteLine(realTotalDesk);




        }
    }
}

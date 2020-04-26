using System;

namespace DancingRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //input Lenght and width of the room and side of square wardrobe 
            //calculate bench measurments and take them off from room space
            //1 dancer needs 7040 square cm to move
            //calculate how many dancers can freely move in the room and roud it to clossest number(MATH.Round)


            double L = double.Parse(Console.ReadLine()) * 100;
            double W = double.Parse(Console.ReadLine()) * 100;
            double A = double.Parse(Console.ReadLine()) * 100;

            double areaCm = L * W;
            double areaWardrobe = (A * A);
            double areaBench = (areaCm / 10);
            double cleanArea = (areaCm - (areaWardrobe + areaBench));
            double dancerSpace = 40 + 7000;

            double numDancers = Math.Floor(cleanArea / dancerSpace);


            

            Console.WriteLine(Math.Floor(numDancers));






        }
    }
}

using System;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallLength = double.Parse(Console.ReadLine()) * 100;
            double hallWidth = double.Parse(Console.ReadLine()) * 100;
            double wardrobeSize = double.Parse(Console.ReadLine()) * 100;

            double hallArea = hallLength * hallWidth;
            double warddrobe = Math.Pow(wardrobeSize, 2);
            double bench = (hallArea / 10);
            double freeHallArea = hallArea - (warddrobe + bench);

            double dancer = 40;
            double dancerNeededSpace = 7000;
            double possibleDancerInTheHall = Math.Floor(freeHallArea / (dancer + dancerNeededSpace));

            Console.WriteLine(possibleDancerInTheHall);
        }
    }
}

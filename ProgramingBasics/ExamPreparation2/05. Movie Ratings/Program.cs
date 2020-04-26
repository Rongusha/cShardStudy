using System;

namespace _05._Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int movieNums = int.Parse(Console.ReadLine());

            string movie = "";
            double averageRate = 0;
            double bestRate = Double.MinValue;
            double shitRate = double.MaxValue;
            string bestMovie = "";
            string shitMovie = "";

            for (int i = 1; i <= movieNums; i++)
            {
                movie = Console.ReadLine();
                double imdbRate = double.Parse(Console.ReadLine());
                averageRate += imdbRate;
                if (imdbRate > bestRate)
                {
                    bestRate = imdbRate;
                    bestMovie = movie;
                }
                if (imdbRate < shitRate)
                {
                    shitRate = imdbRate;
                    shitMovie = movie;
                }
            }
            Console.WriteLine($"{bestMovie} is with highest rating: {bestRate:f1}");
            Console.WriteLine($"{shitMovie} is with lowest rating: {shitRate:f1}");
            Console.WriteLine($"Average rating: {averageRate/movieNums:f1}");
        }
    }
}

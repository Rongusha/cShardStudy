using System;

namespace _05._Easter_Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cackes = int.Parse(Console.ReadLine());

            double shugarGramSum = 0;
           
            double flowerGramSum = 0;
           
            int shugarMax = int.MinValue;
            int flowerMax = int.MinValue;

            for (int i = 1; i <= cackes; i++)
            {
                int gramsShugar = int.Parse(Console.ReadLine());
                shugarGramSum += gramsShugar;
                int gramsFlower = int.Parse(Console.ReadLine());
                flowerGramSum += gramsFlower;

                if (shugarMax<gramsShugar)
                {
                    shugarMax = gramsShugar;
                }
                if (flowerMax<gramsFlower)
                {
                    flowerMax = gramsFlower;
                }
               
            }
            Console.WriteLine($"Sugar: {Math.Ceiling(shugarGramSum/950)}");
            Console.WriteLine($"Flour: {Math.Ceiling(flowerGramSum/750)}");
            Console.WriteLine($"Max used flour is {flowerMax} grams, max used sugar is {shugarMax} grams.");
        }
    }
}

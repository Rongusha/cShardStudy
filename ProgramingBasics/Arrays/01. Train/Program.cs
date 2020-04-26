using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons =int.Parse(Console.ReadLine());

            int[] train = new int[wagons];

            int sumOfPpl = 0;

            for (int i = 0; i < train.Length; i++)
            {
                train[i] =int.Parse(Console.ReadLine());
                sumOfPpl += train[i];
                
                
            }
            foreach (var item in train)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            
            Console.WriteLine(sumOfPpl);


            

        }
    }
}

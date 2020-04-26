using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();


            int counter = 1;
            foreach (int number in numbers)
            {
                bool isSmaller = false;
                for (int i = counter; i < numbers.Length; i++)
                {
                    if (number <= numbers[i])
                    {
                        isSmaller = true;
                    }
                   
                }
                if (!isSmaller)
                {
                    Console.Write($"{number} ");
                    
                }
                counter++;
                

            }

           
        }
    }
}

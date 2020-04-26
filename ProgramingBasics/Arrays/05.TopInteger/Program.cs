using System;
using System.Linq;

namespace _05.TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            
           

            for (int number = 0; number < numbers.Length; number++)
            {
                int current = numbers[number];
                bool isSmaller = false;
                for (int i = number+1; i < numbers.Length; i++)
                {
                    if (current <= numbers[i])
                    {
                        isSmaller = true;
                    }
                    //else
                    //{
                    //    isTop = false;
                    //    break;
                    //}
                }
                if (!isSmaller)
                {
                    Console.Write($"{current} ");
                   
                }
                
            }

        }
    }
}

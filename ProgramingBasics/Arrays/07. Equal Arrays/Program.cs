using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondtArray = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();

            int sum = 0;
            bool isEqual = true;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondtArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isEqual = false;
                    break;
                }
                sum += firstArray[i];
               
            }

            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
           
        }
    }
}

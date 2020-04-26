using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] sum = new int[numbers.Length - 1];

            int lenght = numbers.Length;
            while (lenght > 1)
            {
                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] = numbers[i] + numbers[i + 1];
                    numbers[i] = sum[i];
                    
                }
                lenght --;
            }
            Console.WriteLine(numbers[0]);

        }
    }
}

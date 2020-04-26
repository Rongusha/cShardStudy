using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] numbers = new int[num];

            for (int i = 0; i < num; i++)
            {
                int current = int.Parse(Console.ReadLine());
                numbers[i] = current;
            }
            for (int y = numbers.Length-1 ; y >= 0; y--)
            {
                Console.Write($"{numbers[y]} ");
            }
        }
    }
}

using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }

            }
            int totalSum = sum - max;
            if (totalSum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {totalSum}");
            }
            else
            {

                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(totalSum - max)}");
            }
        }
    }
}

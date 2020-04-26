using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            decimal num2 = 0;
            decimal sum = 0;
            for (int i = 0; i < num; i++)
            {
                num2 = decimal.Parse(Console.ReadLine());
                sum += num2;
            }
            Console.WriteLine(sum);
        }
    }
}

using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum1 = num1 + num2;
            bool isEaqual = true;
            int maxDiff = 0;

            for (int i = 0; i < count -1; i++)
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());

                int sum2 = num1 + num2;

                if (sum1!=sum2)
                {
                    isEaqual = false;
                    maxDiff = Math.Abs(sum1 - sum2);
                }
                sum1 = sum2;

            }
            if (isEaqual)
            {
                Console.WriteLine($"Yes, value={sum1}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
         
        }
    }
}

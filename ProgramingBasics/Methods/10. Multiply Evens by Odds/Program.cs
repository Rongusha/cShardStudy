using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(Math.Abs(input)));
        }

        static int GetSumOfEvenDigits(int even)
        {
            int[] output = even.ToString().Select(t => int.Parse(t.ToString())).ToArray();

            int sum = 0;

            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] % 2 == 0)
                {
                    sum += output[i];
                }

            }

            return sum;
        }

        static int GetSumOfOddDigits(int odd)
        {
            int[] output = odd.ToString().Select(t => int.Parse(t.ToString())).ToArray();

            int sum = 0;

            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] % 2 != 0)
                {
                    sum += output[i];
                }

            }

            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int a)
        {
            int result = ((GetSumOfOddDigits(a)) * (GetSumOfEvenDigits(a)));
            return result;
        }
    }
}

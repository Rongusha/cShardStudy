using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = Console.ReadLine();
            int secondNUm = int.Parse(Console.ReadLine());

            var result = 0;
            var onMind = 0;
            var builder = new StringBuilder();

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int lastDigit = int.Parse(firstNum[i].ToString());
                result = lastDigit * secondNUm + onMind;
                builder.Append(result % 10);
                onMind = result / 10;
            }
            if (onMind != 0)
            {
                builder.Append(onMind);
            }

            var resultString = string.Join("", builder.ToString().Reverse()).TrimStart('0');

            if (resultString == string.Empty)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(resultString);
            }
        }
    }
}

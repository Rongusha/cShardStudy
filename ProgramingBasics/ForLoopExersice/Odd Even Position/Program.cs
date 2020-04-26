using System;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double maxOdd = double.MinValue;
            double maxEven = double.MinValue;
            double minOdd = double.MaxValue;
            double minEven = double.MaxValue;
            double sumOdd = 0;
            double sumEven = 0;

            for (int i = 1; i <= count; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    sumOdd += num;
                    if (num > maxOdd)
                    {
                        maxOdd = num;
                    }
                    if (num < minOdd)
                    {
                        minOdd = num;
                    }
                    
                }
                else
                {
                    sumEven += num;
                    if (num > maxEven)
                    {
                        maxEven = num;
                    }
                    if (num < minEven)
                    {
                        minEven = num;
                    }

                }
            }

            Console.WriteLine($"OddSum={sumOdd:f2},");
            
            if (minOdd == double.MaxValue)
            {
                Console.WriteLine($"OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={minOdd:f2},");
            }
            if (maxOdd == double.MinValue)
            {
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={maxOdd:f2},");
            }

            Console.WriteLine($"EvenSum={sumEven:f2},");

            if (minEven == double.MaxValue)
            {
                Console.WriteLine($"EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={minEven:f2},");
            }
            if (maxEven == double.MinValue)
            {
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={maxEven:f2}");
            }
           
        }
    }
}

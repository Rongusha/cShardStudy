﻿using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 1; i <= numCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2==0)
                {
                    oddSum+=number;
                }
                else
                {
                    evenSum += number;
                }
            }
            if (oddSum==evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum-evenSum)}");
            }
        }
    }
}

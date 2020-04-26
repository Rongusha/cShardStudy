﻿using System;

namespace Proba
{
    using System;

    public static class PrimeTool
    {
        public static bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < num1; i++)
            {
                bool isPrime = PrimeTool.IsPrime(i);
                if (isPrime)
                {
                    Console.WriteLine($"obicham te {i}");
                }
            }
        }
    }
}
﻿using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());

            if (a >= 65 && a <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (a >= 97 && a <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
﻿using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPayments = int.Parse(Console.ReadLine());
            int counter = 0;
            double balance = 0.0;


            while (numOfPayments > counter )
            {
                double amount = double.Parse(Console.ReadLine());
                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += amount;
                Console.WriteLine($"Increase: {amount:f2}");
                counter++;

            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}

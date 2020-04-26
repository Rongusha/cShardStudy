﻿using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine()); 

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numCount; i++)
            {
                int leftNum = int.Parse(Console.ReadLine());
                leftSum += leftNum;
              

            }
            for (int i = 0; i < numCount; i++)
            {
                int rightNum = int.Parse(Console.ReadLine());
                rightSum += rightNum;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum-rightSum)}");
            }
        }
    }
}

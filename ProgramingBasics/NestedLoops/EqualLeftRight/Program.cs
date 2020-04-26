using System;

namespace EqualLeftRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int midnum = 0;
            int rightSum = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                string numToString = i.ToString();
                for (int n = 0; n < numToString.Length; n++)
                {
                    char digit = numToString[n];
                    int digitToNum = int.Parse(digit.ToString());
                    if (n < 2)
                    {
                        leftSum += digitToNum;
                    }
                    else if (n >= 2 && n < 3)
                    {
                        midnum = digitToNum;
                    }
                    else if (n >= 3)
                    {
                        rightSum += digitToNum;
                    }
                }

                if (leftSum > rightSum)
                {
                    rightSum = rightSum + midnum;
                   
                }
                else if (leftSum < rightSum)
                {
                    leftSum = leftSum + midnum;
                   
                }
                if (leftSum == rightSum)
                {
                    Console.Write($"{i} ");
                }
                leftSum = 0;
                midnum = 0;
                rightSum = 0;


            }
        }
    }
}

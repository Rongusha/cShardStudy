using System;

namespace EqualSumEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                string numToString = i.ToString();
                for (int n = 0; n < numToString.Length; n++)
                {
                    char digit = numToString[n];
                    int digitToNum = int.Parse(digit.ToString());
                    if (n%2==0)
                    {
                        evenSum += digitToNum;
                    }
                    else
                    {
                        oddSum += digitToNum;
                    }
                }
                if (evenSum==oddSum)
                {
                    Console.Write($"{i} ");
                    
                    continue;
                }
                evenSum = 0;
                oddSum = 0;
            }
        }
    }
}

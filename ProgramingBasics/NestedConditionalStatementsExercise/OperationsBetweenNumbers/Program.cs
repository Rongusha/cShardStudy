using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = int.Parse(Console.ReadLine());
            double secondNum = int.Parse(Console.ReadLine());
            char action = char.Parse(Console.ReadLine());

            if (action == '+')
            {
                double sum = firstNum + secondNum;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{firstNum} {action} {secondNum} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{firstNum} {action} {secondNum} = {sum} - odd");
                }
            }
            else if (action == '-')
            {
                double sum = firstNum - secondNum;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{firstNum} {action} {secondNum} = {sum} - even");
                }
                else 
                {
                    Console.WriteLine($"{firstNum} {action} {secondNum} = {sum} - odd");
                }
            }
            else if (action == '*')
            {
                double sum = firstNum * secondNum;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{firstNum} {action} {secondNum} = {sum} - even");
                }
                else 
                {
                    Console.WriteLine($"{firstNum} {action} {secondNum} = {sum} - odd");
                }
            }
            else if (action == '/')
            {
                
                if (secondNum == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNum} by zero");
                }
                else
                {
                    double sum = firstNum / secondNum;
                    Console.WriteLine($"{firstNum} / {secondNum} = {sum:f2}");
                }
            }
            else if (action == '%')
            {
                if (secondNum == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNum} by zero");
                }
                else
                {
                    double sum = firstNum % secondNum;
                    Console.WriteLine($"{firstNum} {action} {secondNum} = {sum}");
                }
            }
        }
    }
}

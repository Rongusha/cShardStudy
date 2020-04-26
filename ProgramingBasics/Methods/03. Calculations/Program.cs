using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "subtract":
                    Subtract(firstNumber, secondNumber);
                    break;
                case "divide":
                    divide(firstNumber, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, secondNumber);
                    break;
                case "add":
                    Add(firstNumber, secondNumber);
                    break;
                
            }
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}

using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();

                string resoult = GetMax(first, second);
                Console.WriteLine(resoult);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());

                char resoult = GetMax(first, second);
                Console.WriteLine(resoult);
            }
            else if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                int resoult = GetMax(first, second);
                Console.WriteLine(resoult);
            }
        }

        static string GetMax(string firstToCompare, string secondToCompare)
        {
            int resault = string.Compare(firstToCompare, secondToCompare);
            if (resault<0)
            {
                return secondToCompare;
            }
            else
            {
                return firstToCompare ;
            }
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        static char GetMax(char firstToCompare, char secondToCompare)
        {
            if (firstToCompare >= secondToCompare)
            {
                return firstToCompare;
            }
            else
            {
                return secondToCompare;
            }
        }

    }
}

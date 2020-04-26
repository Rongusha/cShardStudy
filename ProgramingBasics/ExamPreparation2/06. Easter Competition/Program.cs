using System;

namespace _06._Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;//number in question, usually input number
            if (number%2==0)//if number / 2 gives to extra (6/2 = 3 and 0 extra)
            {
                Console.WriteLine("even");//the number is even
            }
            else if (number%2!=0)//or number%2==1. If the number / 2 gives extra (5/2 = 2 and 1 extra)
            {
                Console.WriteLine("odd");//the number is odd
            }
        }
    }
}

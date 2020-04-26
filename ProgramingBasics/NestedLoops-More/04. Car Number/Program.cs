using System;

namespace _04._Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int a = num1; a <= num2; a++)
            {
                for (int b = num1; b <= num2; b++)
                {
                    for (int c = num1; c <= num2; c++)
                    {
                        for (int d = num1; d <= num2; d++)
                        {
                            if (((c+b)%2==0) && (a > d))
                            {
                                if (a>d)
                                {
                                    if ((d % 2 == 0) && (a % 2 != 0))
                                    {
                                        Console.Write($"{a}{b}{c}{d} ");
                                    }
                                    else if ((d % 2 != 0) && (a % 2 == 0))
                                    {
                                        Console.Write($"{a}{b}{c}{d} ");
                                    }
                                }
                               
                            }
                        }
                    }
                }
            }
        }
    }
}

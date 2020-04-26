using System;

namespace Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            char first = num[2];
            char second = num[1];
            char third = num[0];

            int num1 = int.Parse(first.ToString());
            int num2 = int.Parse(second.ToString());
            int num3 = int.Parse(third.ToString());

            for (int i = 1; i <= num1; i++)
            {
                for (int j = 1; j <= num2; j++)
                {
                    for (int y = 1; y <= num3; y++)
                    {
                        if (num1 > 0 && num2 > 0 && num3 > 0)
                        {
                            int sum = i * j * y;
                            Console.WriteLine($"{i} * {j} * {y} = {sum};");
                        }
                    }
                }
            }


        }
    }
}

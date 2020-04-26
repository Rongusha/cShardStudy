using System;

namespace UniquePINCone
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= num1; i++)
            {
                for (int y = 2; y <= num2; y++)
                {
                    for (int x = 1; x <= num3; x++)
                    {
                        int prime = (y);
                        if ((i % 2 == 0 && x % 2 == 0) && ((y == 2 || y == 3)  || (y % 2 != 0 && y % 3 != 0)))
                        {
                            Console.WriteLine($"{i} {y} {x}");
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char thirth = char.Parse(Console.ReadLine());

            int count = 0;

            for (char i = first; i <= second; i++)
            {
               
                for (char y = first; y <= second; y++)
                {
                    for (char x = first; x <= second; x++)
                    {
                        
                        if (i == thirth || y==thirth || x ==thirth)
                        {
                            continue;
                        }
                        Console.Write($"{i}{y}{x} ");

                        count++;
                    }
                }
               
            }
            Console.Write(count);
        }
    }
}

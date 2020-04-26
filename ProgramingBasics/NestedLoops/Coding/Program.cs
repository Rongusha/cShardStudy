using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string num =Console.ReadLine();

            for (int i = num.Length -1; i >= 0; i--)
            {
                char current = num[i];
                int currentToNum =int.Parse(current.ToString());

                if (currentToNum == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }

                for (int n = 1; n <= currentToNum; n++)
                {
                    Console.Write((char)(currentToNum + 33));

                }
                Console.WriteLine();
            }
        }
    }
}

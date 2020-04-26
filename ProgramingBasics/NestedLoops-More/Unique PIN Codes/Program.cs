using System;

namespace Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            for (int i = 1; i <= number.Length; i++)
            {
                char iDigit = number[i];
                int iToNum = int.Parse(number.ToString());
                for (int y = 1; y <= number.Length; y++)
                {
                    char yDigit = number[i];
                    int yToNum = int.Parse(number.ToString());
                    for (int x =1; x <= number.Length; x++)
                    {
                        char xDigit = number[i];
                        int xToNum = int.Parse(number.ToString());
                        if ((i%2==0 && x%2==0) && ((y==2 || y ==3) || (y%2!=0 && y%3!=0)) )
                        {
                            Console.WriteLine($"{i}{y}{x}");
                        }
                    }
                }
            }
        }
    }
}

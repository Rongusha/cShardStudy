using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                string character = i.ToString();
                for (int j = 0; j < character.Length-3; j++)
                {
                    char currentChar = character[j];
                    int jCharToNum = int.Parse(currentChar.ToString());
                    for (int y = 1; y < character.Length-2; y++)
                    {
                        currentChar = character[y];
                        int yCharToNum = int.Parse(currentChar.ToString());
                        for (int x = 2; x < character.Length-1; x++)
                        {
                            currentChar = character[x];
                            int xCharToNum = int.Parse(currentChar.ToString());
                            for (int c = 3; c < character.Length; c++)
                            {
                                currentChar = character[c];
                                int cCharToNum = int.Parse(currentChar.ToString());
                                if (jCharToNum == 0 || yCharToNum == 0 || xCharToNum == 0 || cCharToNum == 0)
                                {
                                    continue;
                                }
                                if (number % jCharToNum == 0 && number % yCharToNum == 0 && number % xCharToNum == 0 && number % cCharToNum == 0)
                                {
                                    Console.Write($"{jCharToNum}{yCharToNum}{xCharToNum}{cCharToNum} ");
                                }

                            }
                        }
                    }
                }

            }
        }
    }
}

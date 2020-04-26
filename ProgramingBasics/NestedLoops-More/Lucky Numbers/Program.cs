using System;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                string iToString = i.ToString();
                for (int y = 0; y < iToString.Length-3 ; y++)
                {
                    char currentDigitY = iToString[y];
                    int digitToNumY = int.Parse(currentDigitY.ToString());
                    for (int x = 1; x < iToString.Length-2; x++)
                    {
                        char currentDigitX = iToString[x];
                        int digitToNumX = int.Parse(currentDigitX.ToString());
                        for (int b = 2; b < iToString.Length-1; b++)
                        {
                            char currentDigitB = iToString[b];
                            int digitToNumB = int.Parse(currentDigitB.ToString());
                            for (int a = 3; a < iToString.Length; a++)
                            {
                                char currentDigitA = iToString[a];
                                int digitToNumA = int.Parse(currentDigitA.ToString());
                                if ((digitToNumY+digitToNumX == digitToNumB+digitToNumA)&&(num%(digitToNumY+digitToNumX)==0))
                                {
                                    if (digitToNumY!=0 && digitToNumX !=0 && digitToNumB!=0 && digitToNumA!=0)
                                    {
                                        Console.Write($"{digitToNumY}{digitToNumX}{digitToNumB}{digitToNumA} ");
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

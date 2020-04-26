using System;

namespace LuckyNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());//Just a case IGNORE

            for (int first = 1; first <= 9; first++)//first digit
            {
                for (int second = 1; second <= 9; second++)//second digit
                {
                    for (int third = 1; third <= 9 ; third++)//third digit
                    {
                        for (int fourth = 1; fourth <= 9; fourth++)//fourth digit
                        {
                            if ((first+second)==(third+fourth))//just a case IGNORE
                            {
                                string number = first.ToString() + second + third + fourth;//make them as one string
                                int luckyNum = int.Parse(number);//convert the string to number
                                if (num % (first + second) == 0)//just a case IGNORE
                                {
                                    Console.Write($"{luckyNum} ");
                                }
                            }
                           
                        }
                    }
                }
            }
        }
    }
}

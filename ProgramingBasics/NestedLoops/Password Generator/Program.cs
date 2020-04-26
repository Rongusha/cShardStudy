using System;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int firstChar = 1; firstChar <= firstNum; firstChar++)
            {
                for (int secondChar = 1; secondChar <= firstNum; secondChar++)
                {
                    int thirdCounter = 1;
                    for (char thirdChar = 'a'; thirdCounter <= secondNum; thirdChar++, thirdCounter++)//thirdChar
                    {
                        int fourthCounter = 1;
                        for (char fourthChar = 'a'; fourthCounter <= secondNum; fourthChar++, fourthCounter++)//fourthChar
                        {
                            for (int fifthChar = 1; fifthChar <= firstNum; fifthChar++)
                            {
                                if (fifthChar > firstChar && fifthChar > secondChar)
                                {
                                    Console.Write($"{firstChar}{secondChar}{thirdChar}{fourthChar}{fifthChar} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace _06._Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());

            double averageSum = 0;
            double itemPrice = 0;
            for (int i = 1; i <= clients; i++)
            {
                string command = Console.ReadLine();

                double sum = 0;
                int itemCount = 0;
                while (command!="Finish")
                {
                    if (command== "basket")
                    {
                        itemPrice = 1.50;
                        sum += itemPrice;
                        itemCount++;
                    }
                    else if (command== "wreath")
                    {
                        itemPrice = 3.80;
                        sum += itemPrice;
                        itemCount++;
                    }
                    else if (command == "chocolate bunny")
                    {
                        itemPrice = 7.0;
                        sum += itemPrice;
                        itemCount++;
                    }
                    command = Console.ReadLine();
                }
                if (itemCount%2==0)
                {
                    sum = sum * 0.80;
                    averageSum += sum;
                }
                else
                {
                    averageSum += sum;
                }
                Console.WriteLine($"You purchased {itemCount} items for {sum:f2} leva.");
            }
            Console.WriteLine($"Average bill per client is: {averageSum/clients:f2} leva.");
        }
    }
}

using System;

namespace _04._Cinema_Voucher
{
    class Program
    {
        static void Main(string[] args)
        {
            double vaucher = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int ticketPrice = 0;
            int ticketCounter = 0;
            int itemPrice = 0;
            int itemCounter = 0;
            int totalPrice = 0;
            while (command != "End")
            {
                if (command.Length > 8)
                {
                    char first = command[0];
                    char second = command[1];
                    int firstToNum = (int)first;
                    int secondToNum = (int)second;
                    ticketPrice = firstToNum + secondToNum;
                    totalPrice += ticketPrice;
                    if (totalPrice > vaucher)
                    {
                        break;
                    }
                    ticketCounter++;
                }
                else
                {
                    int first = (int)command[0];
                    itemPrice = first;
                    totalPrice += itemPrice;
                    if (totalPrice > vaucher)
                    {
                        break;
                    }
                    itemCounter++;
                }

                command =Console.ReadLine();
            }
            Console.WriteLine(ticketCounter);
            Console.WriteLine(itemCounter);
        }
    }
}

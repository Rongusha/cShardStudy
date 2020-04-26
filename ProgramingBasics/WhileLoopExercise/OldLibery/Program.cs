using System;

namespace OldLibery
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int numberOfBooks = int.Parse(Console.ReadLine());
            string nextbook = Console.ReadLine();
            int counter = 0;
            bool isBookFound = false;


            while (counter < numberOfBooks)
            {


                if (favouriteBook == nextbook)
                {
                    isBookFound = true;
                    break;
                }
                nextbook = Console.ReadLine();
                counter++;

            }
            if (isBookFound == true)
            {
                Console.WriteLine($"You checked {counter } books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {numberOfBooks} books.");
            }
            
        }
    }
}

using System;

namespace PromenliviUrok2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Promenlivi belejki:");
            Console.WriteLine("Vsqka promenliva sydyrja tri osnovni komponenta (TYPE), (NAME), (VALUE)!");
            Console.WriteLine("Osnovni Typove promenlivi:");
            int age = 20;
            Console.WriteLine($"za celi chisla = int - primer =  {age}");
            double distance = 175.5;
            Console.WriteLine($"Za drobni chisla = double - primer = {distance}");
            string name = "ASDasd123!@#";
            Console.WriteLine($"Za poredica ot cifri, bukvi i simvoli = string - primer = {name}");
            Char symbol = '@';
            Console.WriteLine($"Za edinichen simvol (character) i se izpolzvat edinichni kavichki = char - primer = {symbol}");
            bool isOn = true;
            Console.WriteLine($"Samo za opredelqne na TRUE ili FALSE = bool - primer = {isOn}");


        }
    }
}

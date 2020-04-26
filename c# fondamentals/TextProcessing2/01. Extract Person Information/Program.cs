using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var input = string.Empty;
            

            for (int i = 0; i < num; i++)
            {
                input = Console.ReadLine();
                int startIndex = input.IndexOf('@');
                int endIndex = input.IndexOf('|');
                var builder = new StringBuilder();
                var age = string.Empty;

                for (int j = startIndex+1; j < endIndex; j++)
                {
                    builder.Append(input[j]);
                }

                startIndex = input.IndexOf('#');
                endIndex = input.IndexOf('*');

                for (int j = startIndex+1; j < endIndex; j++)
                {
                    age += input[j];
                }

                var name = string.Join("", builder);
                var ageToInt = int.Parse(age);

                Console.WriteLine($"{name} is {age} years old.");
                
            }

        }
    }
}

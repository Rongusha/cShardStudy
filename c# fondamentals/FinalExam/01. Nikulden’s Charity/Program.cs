using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _01._Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var input = string.Empty;

            while ((input = Console.ReadLine()) != "Finish")
            {
                var splitted = input.Split().ToArray();
                var command = splitted[0];
                var textToChars = text.ToArray();

                switch (command)
                {
                    case "Replace":

                        var currentChar = char.Parse(splitted[1]);
                        var newChar = char.Parse(splitted[2]);

                        for (int i = 0; i < text.Length; i++)
                        {
                            if (currentChar == textToChars[i])
                            {
                                textToChars[i] = newChar;
                            }
                        }

                        text = string.Join("", textToChars);
                        Console.WriteLine(text);
                        break;

                    case "Cut":

                        var startIndex = int.Parse(splitted[1]);
                        var endIndex = int.Parse(splitted[2]);
                        var count = endIndex - startIndex;

                        if (startIndex >= 0 && endIndex < text.Length)
                        {
                            text = text.Remove(startIndex, count + 1);
                            Console.WriteLine(text);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indexes!");
                        }
                        break;

                    case "Make":

                        var casess = splitted[1];
                        text = text.ToLower();
                        if (casess == "Upper")
                        {
                            text = text.ToUpper();
                        }

                        Console.WriteLine(text);
                        break;

                    case "Check":

                        var subString = splitted[1];
                        if (text.Contains(subString))
                        {
                            Console.WriteLine($"Message contains {subString}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {subString}");
                        }
                        break;

                    case "Sum":

                        startIndex = int.Parse(splitted[1]);
                        endIndex = int.Parse(splitted[2]);
                        count = endIndex - startIndex;
                        if (startIndex >= 0 && endIndex < text.Length)
                        {
                            subString = text.Substring(startIndex, count + 1);
                            var charsSum = new List<int>();

                            foreach (var item in subString)
                            {
                                charsSum.Add((int)item);
                            }

                            Console.WriteLine(charsSum.Sum());
                        }
                        else
                        {
                            Console.WriteLine("Invalid indexes!");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid indexes!");
                        break;
                }
            }
        }
    }
}

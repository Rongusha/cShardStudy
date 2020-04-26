using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var paths = 
             Console.ReadLine()
             .Split(@"\")
             .ToArray();

            string nameAndPath = paths[paths.Length - 1];
            var splitted = nameAndPath.Split(".").ToArray();
            string fileName = splitted[0];
            string filePath = splitted[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {filePath}");
        }
    }
}

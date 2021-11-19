using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] parts = text
                .Split("\\", StringSplitOptions.RemoveEmptyEntries);

            string fileName = parts[parts.Length - 1];

            string[] result = fileName
                .Split(".", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"File name: {result[0]}");
            Console.WriteLine($"File extension: {result[1]}");

            
            
        }
    }
}

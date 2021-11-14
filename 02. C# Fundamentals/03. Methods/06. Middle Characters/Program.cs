using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = GetTheMiddleChar(text);

            Console.WriteLine(result);

        }

        static string GetTheMiddleChar(string text)
        {
            if (text.Length % 2 == 0)
            {
                return $"{text[text.Length / 2 - 1]}{text[text.Length / 2]}";
            }
            return $"{text[(text.Length - 1) / 2]}";
        }
    }
}

using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            char saveSymbol = '\0';
            foreach (char symbol in text)
            {
                if (saveSymbol == symbol)
                {
                    continue;
                }
                else
                {
                    saveSymbol = symbol;
                    sb.Append(saveSymbol);
                } 
            }

            Console.WriteLine(sb);
        }
    }
}

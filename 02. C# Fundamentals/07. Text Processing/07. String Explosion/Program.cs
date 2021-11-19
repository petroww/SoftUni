using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            int bomb = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (symbol == '>')
                {
                    bomb += text[i + 1] - '0';
                    sb.Append(symbol);
                }
                else if (bomb > 0)
                {
                    bomb--;
                }
                else
                {
                    sb.Append(symbol);
                }
            }

            Console.WriteLine(sb);
        }
    }
}

using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (char symbol in text)
            {
                char result = (char)(symbol + 3);
                sb.Append(result);
            }

            Console.WriteLine(sb);
            
        }
    }
}

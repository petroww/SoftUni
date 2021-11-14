using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            PrintSymbolOnASCII(firstSymbol, secondSymbol);
            
           
            
        }

        static void PrintSymbolOnASCII(char firstSymbol,char secondSymbol)
        {
            if (firstSymbol > secondSymbol)
            {
                for (char j = (char)(secondSymbol + 1); j < firstSymbol; j++)
                {
                    Console.Write($"{j} ");
                }
            }

            for (char i = (char)(firstSymbol + 1); i < secondSymbol; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}

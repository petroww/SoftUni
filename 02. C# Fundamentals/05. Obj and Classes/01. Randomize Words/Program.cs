using System;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listOfWords = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Random rnd = new Random();

            for (int i = 0; i < listOfWords.Length; i++)
            {
                int position = rnd.Next(listOfWords.Length);

                string words = listOfWords[i];
                listOfWords[i] = listOfWords[position];
                listOfWords[position] = words;
            }

            Console.WriteLine(string.Join(Environment.NewLine, listOfWords));
        }
    }
}

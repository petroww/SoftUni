using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Mirror_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex reg = new Regex(@"([@|#]{1})(?<word>[a-zA-Z]{3,})\1\1(?<secondword>[a-zA-Z]{3,})\1");

            MatchCollection matchess = reg.Matches(text);

            List<string> firstWord = new List<string>();
            List<string> secondWord = new List<string>();
            List<string> mirrorWords = new List<string>();

            foreach (Match item in matchess)
            {
                firstWord.Add(item.Groups["word"].Value);
                secondWord.Add(item.Groups["secondword"].Value);
            }


            for (int i = 0; i < secondWord.Count; i++)
            {
                string word = secondWord[i];
                string reverse = "";

                for (int j = word.Length - 1; j >= 0; j--)
                {
                    reverse += word[j];
                }
                secondWord[i] = reverse;

            }

            for (int i = 0; i < firstWord.Count; i++)
            {
                for (int j = 0; j < secondWord.Count; j++)
                {
                    if (firstWord[i] == secondWord[j])
                    {
                        mirrorWords.Add(firstWord[i]);
                    }
                }
            }
            List<string> reversedMirror = new List<string>();

            for (int i = 0; i < mirrorWords.Count; i++)
            {
                string currentWord = mirrorWords[i];

                string revers = "";
                for (int j = currentWord.Length - 1; j >= 0; j--)
                {
                    revers += currentWord[j];
                }
                reversedMirror.Add(revers);
            }

            if (firstWord.Count < 1)
                Console.WriteLine("No word pairs found!");
            else
                Console.WriteLine($"{firstWord.Count} word pairs found!");

            List<string> mirror = new List<string>();

            if (mirrorWords.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                for (int i = 0; i < mirrorWords.Count; i++)
                {
                    string asd = ($"{mirrorWords[i]} <=> {reversedMirror[i]}");
                    mirror.Add(asd);
                }
                Console.WriteLine(string.Join(", ", mirror));
            }
            else
                Console.WriteLine("No mirror words!");
        }
    }
}

using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] password = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            bool isVallid = false;

            foreach (var word in password)
            {
                
                if (word.Length >= 3 && word.Length < 16)
                {
                    foreach (char symbol in word)
                    {
                        if (symbol == '_' || symbol == '-' || char.IsLetterOrDigit(symbol))
                        {
                            isVallid = true;
                        }
                        else
                        {

                            isVallid = false;
                            break;
                        }

                    }
                }
                if (isVallid)
                {
                    Console.WriteLine(word);
                }
                isVallid = false;
            }

            
    }   }
}

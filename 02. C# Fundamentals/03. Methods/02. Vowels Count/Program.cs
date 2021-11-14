using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            int result = FindTheVowels(text);

            Console.WriteLine(result);

        }

        static int FindTheVowels(string text)
        {
            int counter = 0; 
            foreach (char item in text.ToLower())
            {
                if (item == 'a')
                {
                    counter++;
                }
                else if (item == 'e')
                {
                    counter++;
                }
                else if (item == 'i')
                {
                    counter++;
                }
                else if (item == 'o')
                {
                    counter++;
                }
                else if (item == 'u')
                {
                    counter++;
                }
                else if (item == 'y')
                {
                    counter++;
                }
            }
            return counter;
        }



    }
}

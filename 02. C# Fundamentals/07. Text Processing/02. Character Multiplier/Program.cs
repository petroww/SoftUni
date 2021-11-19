using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstNiz = words[0];
            string secondNiz = words[1];

            int result = 0;
            int counter = 0;
            
            for (int i = 0; i < Math.Min(firstNiz.Length,secondNiz.Length); i++)
            {
                counter++;
                result += firstNiz[i] * secondNiz[i];
            }

            if (firstNiz.Length > secondNiz.Length)
            {
                for (int i = counter; i < firstNiz.Length; i++)
                {
                    result += firstNiz[i];
                }
            }
            else
            {
                for (int i = counter; i < secondNiz.Length; i++)
                {
                    result += secondNiz[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}

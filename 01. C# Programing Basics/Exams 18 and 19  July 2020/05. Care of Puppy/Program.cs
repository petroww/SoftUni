using System;

namespace CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int pupiesFood = int.Parse(Console.ReadLine());


            int sum = 0;
            int boughtFood = pupiesFood * 1000;

            string word = Console.ReadLine();
            while (!word.Equals("Adopted"))
            {

                int input = Int32.Parse(word);
                sum += input;

                word = Console.ReadLine();
            }

            if (boughtFood >= sum)
            {
                Console.WriteLine($"Food is enough! Leftovers: {boughtFood - sum} grams.");
            }
            else
                Console.WriteLine($"Food is not enough. You need {sum - boughtFood} grams more.");

        }
    }
}
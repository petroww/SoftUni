using System;

namespace Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double freeSpace = double.Parse(Console.ReadLine());

            var word = Console.ReadLine();
            int counter = 0;

            double sum = 0;

            while (!word.Equals("End"))
            {
                double input = double.Parse(word);
                counter++;

                sum += input;

                if (counter % 3 == 0)
                {
                    input = input * 0.10;
                    sum += input;
                }

                if (sum > freeSpace)
                {
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {counter - 1} suitcases loaded.");

                    break;
                }

                word = Console.ReadLine();
            }

            if (word == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
                Console.WriteLine($"Statistic: {counter} suitcases loaded.");

            }
        }
    }
}

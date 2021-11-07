using System;

namespace If_Statement_Advance_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double price = 0;

            if (word == "Premiere")
                price = price + (row * column) * 12.0;
            else if (word == "Normal")
                price = price + (row * column) * 7.5;
            else if (word == "Discount")
                price = price + (row * column) * 5;

            Console.WriteLine($"{price:F2} leva");

        }
    }
}

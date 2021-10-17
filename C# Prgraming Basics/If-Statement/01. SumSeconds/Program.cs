using System;

namespace Coditional_Statemant_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int suming = first + second + third;

            int minutes = suming / 60;
            int secounds = suming % 60;

            if (secounds < 10)
            {
                Console.WriteLine($"{minutes}:0{secounds}");
            }
            else
                Console.WriteLine($"{minutes}:{secounds}");
        }
    }
}

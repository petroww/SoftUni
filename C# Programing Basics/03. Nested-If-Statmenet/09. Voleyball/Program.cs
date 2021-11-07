using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double weekendsInSofiq = 48 - h;

            double saturdayInSofiq = weekendsInSofiq * 3 / 4;

            double holidays = p * 2 / 3;

            double totalGames = saturdayInSofiq + h + holidays;

            if (word == "leap")
            {

                totalGames = totalGames + (totalGames * 15 / 100);

            }
            Console.WriteLine("{0}", Math.Floor(totalGames));
        }
    }
}

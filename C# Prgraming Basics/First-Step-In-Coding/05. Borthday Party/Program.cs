using System;
using System.Dynamic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceForHell = double.Parse(Console.ReadLine());

            var cake = priceForHell * 20 / 100;

            var drinks = cake - (cake * 45 / 100);

            var Anime = priceForHell / 3;

            Console.WriteLine(priceForHell + cake + drinks + Anime);

        }
    }
}

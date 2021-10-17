using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var usdForConvert = double.Parse(Console.ReadLine());
            var result = usdForConvert * 1.79549;

            Console.WriteLine(result);
        }
    }
}
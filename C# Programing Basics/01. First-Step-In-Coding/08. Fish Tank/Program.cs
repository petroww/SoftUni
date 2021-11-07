using System;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double duljine = double.Parse(Console.ReadLine());
            double shirochina = double.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double obem = duljine * shirochina * visochina;
            double obshoLitri = obem * 0.001;
            double procent = percent * 0.01;
            double sum = obshoLitri * (1 - procent);

            Console.WriteLine(sum);
        }
    }
}
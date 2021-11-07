using System;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input > max)
                {
                    max = input;
                }
                sum += input;
            }
            int totalSum = sum - max;

            if (totalSum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {totalSum}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(totalSum - max)}");
            }
        }
    }
}

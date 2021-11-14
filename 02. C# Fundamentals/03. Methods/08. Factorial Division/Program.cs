using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            double firstFactorial = GetTheFactorial(factorial);
            double secondFactorial = GetTheFactorial(number);
            double result = firstFactorial / secondFactorial;
            Console.WriteLine($"{result:F2}");
            
        }

        static double GetTheFactorial(int factorial)
        {
            double factorialSum = 1;
            for (int i = 2; i <= factorial; i++)
            {
                factorialSum *= i;
            }
            return factorialSum;
        }
    }
}

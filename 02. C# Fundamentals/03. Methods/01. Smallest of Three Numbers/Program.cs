using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = GetTheMinOfDigits(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine(result);

        }

        static int GetTheMinOfDigits(int firstNumber, int secondNumber, int thirdNumber)
        {
            int minDigits = Math.Min(Math.Min(firstNumber, secondNumber), thirdNumber);

            return minDigits;


        }
    }
}

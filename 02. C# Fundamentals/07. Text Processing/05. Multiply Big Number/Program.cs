using System;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            BigInteger result = BigInteger.Parse(firstNumber) * number;

            Console.WriteLine(result.ToString());

            

            
        }
    }
}

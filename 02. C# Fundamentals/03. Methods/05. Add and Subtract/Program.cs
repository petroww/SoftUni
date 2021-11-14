using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = GetResultOFNumbers(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine(result);

        }
        

        static int GetResultOFNumbers(int firstNumber,int secpondNumber,int thirdNumber)
        {
            int sumNumber = firstNumber + secpondNumber;
            int result = sumNumber - thirdNumber;
            return result;
        }
    }
}

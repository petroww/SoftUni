using System;

namespace Equal_Sum_Even_Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            var num1 = Console.ReadLine();
            var num2 = Console.ReadLine();

            int even_Sum = 0;

            int odd_Sum = 0;

            for (int i = int.Parse(num1); i <= int.Parse(num2); i++)
            {
                num1 = i.ToString();

                odd_Sum = (int)Char.GetNumericValue(num1[0]) + (int)Char.GetNumericValue(num1[2]) + (int)Char.GetNumericValue(num1[4]);

                even_Sum = (int)Char.GetNumericValue(num1[1]) + (int)Char.GetNumericValue(num1[3]) + (int)Char.GetNumericValue(num1[5]);

                if (even_Sum == odd_Sum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
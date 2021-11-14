using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            GetTheMatrix(number);
        }

        static void GetTheMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {

                for (int j = 0; j < number; j++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}

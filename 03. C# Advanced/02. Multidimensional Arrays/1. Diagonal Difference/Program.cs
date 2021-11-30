using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfSquareMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeOfSquareMatrix, sizeOfSquareMatrix];
            fullingMatrix(matrix);
            NewMethod(matrix);
        }

        private static void NewMethod(int[,] matrix)
        {
            int row = 0;

            int sumOne = 0;
            int sumTwo = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sumOne += matrix[row, col];
                row++;
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sumTwo += matrix[row - 1, col];
                row--;
            }


            int result = Math.Abs(sumOne - sumTwo);
            Console.WriteLine(result);
        }

        private static void fullingMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = input[col];
                }
            }
        }

    }
}

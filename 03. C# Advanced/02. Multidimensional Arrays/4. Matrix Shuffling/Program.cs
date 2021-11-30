using System;
using System.Linq;

namespace Matrix_Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray(); ;

            string[,] matrix = new string[sizeMatrix[0], sizeMatrix[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] splitCommand = command.Split();

                string swap = splitCommand[0];
                if (swap != "swap" || splitCommand.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row1 = Convert.ToInt32(splitCommand[1]);
                int col1 = Convert.ToInt32(splitCommand[2]);

                int row2 = Convert.ToInt32(splitCommand[3]);
                int col2 = Convert.ToInt32(splitCommand[4]);
                // bool checkCoordinations =

                int lengtRowMatrix = matrix.GetLength(0);
                int lengtColMatrix = matrix.GetLength(1);

                bool check1 = row1 < lengtRowMatrix && row1 >= 0 &&
                    col1 < lengtColMatrix && col1 >= 0;



                bool check2 = row2 < lengtRowMatrix && row2 >= 0 &&
                    col2 < lengtColMatrix && col2 >= 0;

                if (check1 == false || check2 == false)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    string takeElement = matrix[row1, col1];

                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = takeElement;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write($"{matrix[row, col]} ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }


    }
}

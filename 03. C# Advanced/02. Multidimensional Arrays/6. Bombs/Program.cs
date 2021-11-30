using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrentTask
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Damage area locations
            Queue<Tuple<int, int>> damageAreaLocations = new Queue<Tuple<int, int>>();
            damageAreaLocations.Enqueue(new Tuple<int, int>(-1, -1));
            damageAreaLocations.Enqueue(new Tuple<int, int>(-1, 0));
            damageAreaLocations.Enqueue(new Tuple<int, int>(-1, 1));
            damageAreaLocations.Enqueue(new Tuple<int, int>(0, 1));
            damageAreaLocations.Enqueue(new Tuple<int, int>(1, 1));
            damageAreaLocations.Enqueue(new Tuple<int, int>(1, 0));
            damageAreaLocations.Enqueue(new Tuple<int, int>(1, -1));
            damageAreaLocations.Enqueue(new Tuple<int, int>(0, -1));

            /// Filling the matrix
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] curRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = curRow[k];
                }
            }

            /// Colecting explode locations
            Stack<Tuple<int, int>> bombs = new Stack<Tuple<int, int>>();
            string[] bombLocations = Console.ReadLine().Split();
            for (int i = bombLocations.Length - 1; i >= 0; i--)
            {
                int[] curLocation = bombLocations[i].Split(",").Select(int.Parse).ToArray();
                int curRow = curLocation[0];
                int curCol = curLocation[1];
                bombs.Push(new Tuple<int, int>(curRow, curCol));
            }

            ///Goind trough the bombs and exploding them
            int bombCounter = bombs.Count;
            for (int j = 0; j < bombCounter; j++)
            {
                int curBombRow = bombs.Peek().Item1;
                int curBombCol = bombs.Peek().Item2;
                if (matrix[curBombRow, curBombCol] > 0)
                {
                    bombs.Pop();
                    int curBombDamageValue = matrix[curBombRow, curBombCol];
                    matrix[curBombRow, curBombCol] = 0;

                    //Going trough the locationa that take damage
                    for (int l = 0; l < damageAreaLocations.Count; l++)
                    {
                        int damageRow = damageAreaLocations.Peek().Item1;
                        int damageCol = damageAreaLocations.Peek().Item2;
                        damageAreaLocations.Enqueue(damageAreaLocations.Dequeue());
                        try
                        {
                            if (matrix[curBombRow + damageRow, curBombCol + damageCol] > 0)
                            {
                                matrix[curBombRow + damageRow, curBombCol + damageCol] -= curBombDamageValue;
                            }
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                }
            }

            int resultSum = 0;
            int liveCells = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, k] > 0)
                    {
                        resultSum += matrix[i, k];
                        liveCells++;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {liveCells}");
            Console.WriteLine($"Sum: {resultSum}");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write(matrix[i, k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
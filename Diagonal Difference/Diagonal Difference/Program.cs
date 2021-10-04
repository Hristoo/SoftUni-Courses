using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputIntigers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputIntigers[col];
                }
            }

            int primaryDyagonal = 0;
            int secondDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primaryDyagonal += matrix[i, i];

            }
            int counter = matrix.GetLength(1) - 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                secondDiagonal += matrix[i, counter];
                counter--;
            }

            Console.WriteLine(Math.Abs(primaryDyagonal - secondDiagonal));
        }
    }
}

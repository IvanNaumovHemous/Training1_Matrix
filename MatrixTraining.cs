using System;

namespace DescendingMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = GetMatrix(sizeOfMatrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] GetMatrix(int size)
        {
            var matrix = new int[size, size];

            for (int i = 0, col = i + 1; i < matrix.GetLength(0); i++, col = i + 1)
            {
                for (int j = 0; j < matrix.GetLength(1); j++, col++)
                {
                    matrix[i, j] = col;
                }
                
            }

            return matrix;
        }
    }
}

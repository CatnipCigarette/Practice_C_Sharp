using System;

namespace MySpace
{
    public static class MatrixExt
    {
        public static int RowsCount(this int[,] matrix)
        {
            return matrix.GetUpperBound(0) + 1;
        }

        public static int ColumnsCount(this int[,] matrix)
        {
            return matrix.GetUpperBound(1) + 1;
        }

    }

    class Program
    {
        static int[,] GetMatrixFromConsole(string name)
        {
            Console.Write("Количество строк матрицы {0}: ", name);
            var n = int.Parse(Console.ReadLine());
            Console.Write("Количество столбцов матрицы {0}: ", name);
            var m = int.Parse(Console.ReadLine());

            var matrix = new int[n, m];
            Random rand = new Random();

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(0, 10);
                }
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (var i = 0; i < matrix.RowsCount(); i++)
            {
                for (var j = 0; j < matrix.ColumnsCount(); j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }

                Console.WriteLine();
            }
        }

        static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
        {
            if (matrixA.ColumnsCount() != matrixB.RowsCount())
            {
                throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            }

            var matrixC = new int[matrixA.RowsCount(), matrixB.ColumnsCount()];

            for (var i = 0; i < matrixA.RowsCount(); i++)
            {
                for (var j = 0; j < matrixB.ColumnsCount(); j++)
                {
                    matrixC[i, j] = 0;

                    for (var k = 0; k < matrixA.ColumnsCount(); k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return matrixC;
        }

        static void Main(string[] args)
        {

            var a = GetMatrixFromConsole("A");
            Console.WriteLine();
            var b = GetMatrixFromConsole("B");

            Console.WriteLine();
            Console.WriteLine("Матрица A:");
            PrintMatrix(a);

            Console.WriteLine();
            Console.WriteLine("Матрица B:");
            PrintMatrix(b);

            Console.WriteLine();
            var result = MatrixMultiplication(a, b);
            Console.WriteLine("Произведение матриц:");
            PrintMatrix(result);

            Console.ReadLine();
        }
    }
}
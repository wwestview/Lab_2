using System;

class Block2
{
    static void Main()
    {
        Console.Write("Enter size of matrix: ");
        string[] input = Console.ReadLine().Split(' ');
        int rows = int.Parse(input[0]);
        int cols = int.Parse(input[1]);

        int[,] originalMatrix = AnnounceMatrix(rows, cols);

        int[,] transposedMatrix = TransposeMatrix(originalMatrix);

        PrintTranspose (transposedMatrix);
    }

    static int[,] AnnounceMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Console.WriteLine($"Enter elements of Matrix {rows}x{cols}:");
        for (int i = 0; i < rows; i++)
        {
            string[] rowValues = Console.ReadLine().Split();
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Convert.ToInt16(rowValues[j]);
            }
        }
        return matrix;
    }

    static int[,] TransposeMatrix(int[,] matrix)
    {

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transposedMatrix = new int[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }
        return transposedMatrix;
    }

    static void PrintTranspose(int[,] matrix)
    {
        Console.WriteLine("Transpose Matrix ");
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write(matrix[rows, cols] + " ");
            }
            Console.WriteLine();
        }
    }
}


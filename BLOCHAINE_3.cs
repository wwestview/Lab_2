using System;

class BLOCHAINE_3
{
    static void Main()
    {
        Console.Write("Enter size of matrix: ");
        string[] input = Console.ReadLine().Split(' ');
        int rows = int.Parse(input[0]);
        int cols = int.Parse(input[1]);
        int[,] originalMatrix = AnnounceMatrix(rows, cols);
        SortMatrixByMaxElement(originalMatrix);
        Console.WriteLine("--------------------");
        PrintMatrix(originalMatrix);
    }

    static void SortMatrixByMaxElement(int[,] matrix)
    {
        int maxRow = matrix.MaxRow();
        int maxCol = matrix.MaxCol();
        matrix.SortRows(maxRow, maxCol);
    }

    static int[,] AnnounceMatrix(int rows, int cols)
    {
        int[,] originalMatrix = new int[rows, cols];
        Console.WriteLine($"Введіть елементи матриці {rows}x{cols}:");
        for (int i = 0; i < rows; i++)
        {
            string[] rowValues = Console.ReadLine().Split();
            for (int j = 0; j < cols; j++)
            {
                originalMatrix[i, j] = int.Parse(rowValues[j]);
            }
        }
        return originalMatrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

public static class ArrayMatrix
{
    public static void SortRows(this int[,] matrix, int maxRow, int maxCol)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int maxElement = matrix[maxRow, maxCol];
        for (int i = 0; i < rows; i++)
        {
            if (matrix[i, maxCol] == maxElement)
            {
                for (int j = 0; j < cols; j++)
                {
                    for (int k = 0; k < cols - 1 - j; k++)
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                }
            }
        }
    }

    public static int MaxRow(this int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int maxElement = matrix[0, 0];
        int maxRow = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > maxElement)
                {
                    maxElement = matrix[i, j];
                    maxRow = i;
                }
            }
        }
        return maxRow;
    }

    public static int MaxCol(this int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int maxElement = matrix[0, 0];
        int maxCol = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > maxElement)
                {
                    maxElement = matrix[i, j];
                    maxCol = j;
                }
            }
        }
        return maxCol;
    }
}

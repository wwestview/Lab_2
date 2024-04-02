using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.Write($"Enter size of matrix: ");
        string[] input = Console.ReadLine().Split(' ');
        int rows = int.Parse(input[0]);
        int cols = int.Parse(input[1]);
        int[,] originalMatrix = AnnounceMatrix(rows, cols);
        ColumnsBySum(originalMatrix);
        Console.WriteLine("-----");
        PrintMatrix(originalMatrix);
        
    }

    static void ColumnsBySum(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
       int[]columnSums = SumCol(matrix);
        for (int i = 0; i < columns ; i++)
        {
            for (int j = 0; j < columns - i - 1; j++)
            {
                if (columnSums[j] > columnSums[j + 1])
                {
                    for (int k = 0; k < rows; k++)
                    {
                        int temp = matrix[k, j];
                        matrix[k, j] = matrix[k, j + 1];
                        matrix[k, j + 1] = temp;
                    }
                    int tempSum = columnSums[j];
                    columnSums[j] = columnSums[j + 1];
                    columnSums[j + 1] = tempSum;
                }

            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public static int[]SumCol(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        int[] columnSums = new int[columns];
        for (int j = 0; j < columns; j++)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += matrix[i, j];
            }
            columnSums[j] = sum;

            Console.WriteLine($"Sum columns <{columnSums[j]}> ");
        }
        return columnSums;
    }
    static int[,]AnnounceMatrix(int rows,int columns)
    {
        int[,] originalMatrix = new int[rows, columns];
        Console.WriteLine($"Enter elements of Matrix {rows}x{columns}:");
        for (int i = 0; i < rows; i++)
        {
            string[] rowValues = Console.ReadLine().Split();
            for (int j = 0; j < columns; j++)
            {
                originalMatrix[i, j] = int.Parse(rowValues[j]);
            }
        }
        return originalMatrix;
    }
   



}




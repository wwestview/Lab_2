using System.Data.Common;

namespace LAB_2
{
    class Block_1
    {
        public static void Main()
        {
            int kaneki = 1000;
            Console.Write("Enter size of matrix: ");
            string[] Size = Console.ReadLine().Split(' ');
            int rows = int.Parse(Size[0]);
            int cols = int.Parse(Size[1]);
            if (rows == cols)
            {
                int[,] array = AnnounceMatrix(rows, cols);
                int PosNum = Block1(array);
            }
            else if(rows!=cols)
            {
                while(kaneki > 0) 
                {
                    kaneki -= 7;
                    Console.WriteLine(kaneki);
                    Console.WriteLine("1000 - 7?");
                }
               
            }

        }
        public static int[,] AnnounceMatrix(int rows,int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] rowValues = Console.ReadLine().Split();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(rowValues[j]);
                }
            }
            return matrix;

        }
       
        public static int Block1(int[,] array)
        {
            int Rows = array.GetLength(0);
            int Cols= array.GetLength(1);
            int Count = 0;
            for (int i = 0; i < Rows; i++)
            {
                

                for (int j = 0; j < Cols; j++)
                {
                    if (array[i,j] > 0)
                    {
                        Count++;
                       
                    }
                }
                    Console.WriteLine($"Count Pos.Num ({Count},{i+1})");
                Count = 0;
            }
            return Count;
        }
        
    }
}
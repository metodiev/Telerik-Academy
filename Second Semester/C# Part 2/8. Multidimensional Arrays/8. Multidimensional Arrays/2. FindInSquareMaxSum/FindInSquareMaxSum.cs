using System;

//Write a program that reads a rectangular matrix of 
//size N x M and finds in it the square 3 x 3 that 
//has maximal sum of its elements.

class FindInSquareMaxSum
{
    static void Main()
    {
        //matrwix NxM
        
        //Console.WriteLine("Enter N:");
        //int N = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter M:");
        //int M = int.Parse(Console.ReadLine());
        //int [,] matrix = new int[N,M];

        //for (int row = 0; row < N; row++)
        //{
        //    for (int col = 0; col < N; col++)
        //    {
        //        matrix[row, col] = col;
        //    }
        //}

        //Matrix from C# book
        int[,] matrix = {
                            { 0, 2, 4, 0, 9, 5 },
                            { 7, 1, 3, 3, 2, 1 },
                            { 1, 3, 9, 8, 5, 6 },
                            { 4, 6, 7, 9, 1, 0 }
                        };
        
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        int currentSum = 0;

        for (int i = 0; i <= matrix.GetLength(0) - 3; i++)
        {
            for (int j = 0; j <= matrix.GetLength(1) - 3; j++)
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        currentSum += matrix[row + i, col + j];
                    }
                }

                if (currentSum >= bestSum)
                {
                    bestSum = currentSum;
                    bestRow = i;
                    bestCol = j;
                }
            }
        }

        int[,] endMatrix = new int[3, 3];
        //Best 3 rows and cols
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                endMatrix[i, j] = matrix[bestRow + i, bestCol + j];
            }
        }

        //Print Matrix
        Console.WriteLine("The best platform is:");

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(endMatrix[row, col]+" ");
            }

            Console.WriteLine();
        }
    }
}


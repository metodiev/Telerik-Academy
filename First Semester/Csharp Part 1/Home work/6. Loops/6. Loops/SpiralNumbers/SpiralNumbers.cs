using System;

//* Write a program that reads a positive integer 
//N N (N < 20) from console and outputs in 
//the console the Ns 1 ... N Ns 
//arranged as a spiral.

class SpiralNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer number N:");
        int N = int.Parse(Console.ReadLine());
        int rows = N - 1;
        int columns = N - 1;
        int arrRow = 0;
        int count = 1;
        int[,] arr = new int[N, N];

        for ( int col = 0; col < N && count <= N*N; col++)
        {      
            for (int i = col; i <= columns; i++)
            {
                arr[arrRow, i] = count;                              
                count++;
            }

            arrRow++;

            for (int i = arrRow; i <= rows; i++)
            {
                arr[i, columns] = count;                           
                count++;
            }

            columns--;

            for (int i = columns; i >= col; i--)
            {
                arr[rows, i] = count;                           
                count++;
            }

           --rows;

            for (int i = rows; i >= arrRow; i--)
            {
                arr[i, col] = count;                              
                count++;
            }
        }

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write(" " + arr[row, col]);
            }
            Console.WriteLine();
        }
    }
}

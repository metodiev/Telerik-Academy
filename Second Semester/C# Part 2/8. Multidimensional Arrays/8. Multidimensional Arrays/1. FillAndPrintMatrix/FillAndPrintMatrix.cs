using System;

//Write a program that fills and prints a matrix 
//of size (n, n) as shown below: (examples for n = 4)

class FillAndPrintMatrix
{
   public static void PrintMatrix(int size)
    {
          for (int i = 1; i<= size; i++)
        {
            for (int j = i; j <= size*size; j+=size)
            {
                Console.Write("  " + j);
            }
            Console.WriteLine();
        }
    }

   public static void PrintDifficult(int N)
   {

      
       int rows = N - 1;
       int columns = N - 1;
       int arrRow = 0;
       int count = 1;
       int[,] arr = new int[N, N];

       for (int col = 0; col < N && count <= N * N; col++)
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
       Console.WriteLine("\n\n\n");
       for (int row = 0; row < arr.GetLength(0); row++)
       {
           for (int col = 0; col < arr.GetLength(1); col++)
           {
               Console.Write("  " + arr[row, col]);
           }
           Console.WriteLine();
       }
   }

   public static void Main()
    {
        Console.WriteLine("Enter n:");
        int size = int.Parse(Console.ReadLine());
        PrintMatrix(size);
       // Dificult matrix print
        PrintDifficult(size);
    }
}



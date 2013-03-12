using System;
using System.IO;
using System.Text;

//Write a program that reads a text file containing a square matrix of
//numbers and finds in the matrix an area of size 2 x 2 with a maximal 
//sum of its elements. The first line in the input file contains the size 
//of matrix N. Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file. Example:
//4
//2 3 3 4
//0 2 3 4			17
//3 7 1 2
//4 3 3 2

class FindInMatrixAnArea
{
    private static int ConvertToInt(int digit)
    {
        int num = 0;
        for (int i = 48, j=0; i < 58; j++,i++)
        {
            if (digit == i)
            {
                num = j;
            }
        }

        return num;
    }

    private static void BestPlatform(int [,] matrix)
    {
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] +
                matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        // Print the result
        Console.WriteLine("The best platform is:");
        Console.WriteLine(" {0} {1}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]);
        Console.WriteLine(" {0} {1}",
        matrix[bestRow + 1, bestCol],
        matrix[bestRow + 1, bestCol + 1]);
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }

    static void Main()
    {
       int[,] matrix =  {
        {2, 3, 3, 4},
        {0, 2, 3, 4},
        {3, 7, 1, 2},
        {4, 3, 3, 2} 
        };
       StreamWriter writer = new StreamWriter("file.txt");

       using (writer)
       {
           string [] arr = new string[4];

           for (int row = 0; row < matrix.GetLength(0); row++)
           {
               for (int col = 0; col < matrix.GetLength(1); col++)
               {
                 arr[col]= (matrix[row,col]).ToString();
               }

               for (int i = 0; i < arr.Length; i++)
               {
                   writer.Write(arr[i]);
               }

               writer.WriteLine();
               
            }
        }

       StreamReader readRow = new StreamReader("file.txt");
       int row1 = 0;
       using (readRow)
       {
            row1 = readRow.ReadLine().Length;
            Console.WriteLine(row1);
       }
           
       StreamReader readCol = new StreamReader("file.txt");
       int col1 = 0;
       using (readCol)
       {
           while (readCol.ReadLine() != null)
           {
               col1++;
           }
           Console.WriteLine(col1);
       }

       StreamReader readMatrix = new StreamReader("file.txt");

       using (readMatrix)
       {
           int[,] textMatrix = new int[row1, col1];
           for (int row = 0; row < textMatrix.GetLength(0); row++)
           {
               for (int col = 0; col < textMatrix.GetLength(1); col++)
               {
                   int digit = readMatrix.Read();
                   int p = ConvertToInt(digit);
                   textMatrix[row, col] = p;
               }
               readMatrix.ReadLine();
           }

           Console.WriteLine("Matrix after text file is read:");
           for (int row = 0; row < textMatrix.GetLength(0); row++)
           {
               for (int col = 0; col < textMatrix.GetLength(1); col++)
               {
                   Console.Write(textMatrix[row, col]);
               }
               Console.WriteLine();
           }

           BestPlatform(textMatrix);
           
       }
    }
}


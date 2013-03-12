using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    private static void RecursiveMethod(int[] arr, int n, int index = 0)
    {
        int size = arr.Length;

        if (index == arr.Length)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }

        else
        {
            for (int i = 1; i <= n; i++)
            {
                arr[index] = i;
                RecursiveMethod(arr, n, index + 1);
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter N");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K:");
        int K = int.Parse(Console.ReadLine());
        int[] arr = new int[K];

        RecursiveMethod(arr, N);
    }
    //static void Main()
    //{



        //int N = int.Parse(Console.ReadLine());
        //int nSquare = N * 2;

        //string[,] str = new string[nSquare, N];

        //for (int row = 0; row < nSquare; row++)
        //{
        //    for (int col = 0; col < N; col++)
        //    {
        //        str[row, col] = Console.ReadLine();
        //    }
        //}


        //int checkVertical = 1;
        //int checkVerticalMax = 1;
        //string vertical = null;


        //for (int col = 0; col < str.GetLength(1); col++)
        //{
        //    for (int row = 0; row < str.GetLength(0) - 1; row++)
        //    {
        //        if (str[row, col] == str[row + 1, col])
        //        {
        //            checkVertical++;
        //            if (checkVertical >= checkVerticalMax)
        //            {
        //                vertical = str[row, col];
        //                checkVerticalMax = checkVertical;
        //            }
        //        }

        //        else
        //        {
        //            checkVertical = 1;
        //        }
        //    }
        //}

        //string[] arr = new string[2];
        //arr[0] = vertical;
        //arr[1] = checkVerticalMax.ToString();
        //Console.WriteLine(vertical);
    //}
}


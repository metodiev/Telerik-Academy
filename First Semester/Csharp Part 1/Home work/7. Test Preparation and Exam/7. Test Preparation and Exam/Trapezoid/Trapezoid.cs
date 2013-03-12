using System;

//Input:
//The input data is being read from the console.
//On the only line in the console you are given an integer number N, showing the width of the smallest trapezoid side.
//The input data will always be valid and in the format described. There is no need to check it explicitly.

//Output:
//The output data must be printed on the console.
//You must write the border of the described trapezoid on the console.
//Use the symbol “*” (asterisk) to mark the border of the trapezoid.
//Use the symbol “.” (dot) to illustrate the empty spaces outside and inside the trapezoid.

//Constraints:
//The number N is a positive integer between 3 and 39, inclusive.


class Program
{
    static void Main()
    {  
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write(".");
        }

        for (int j = 0; j < n; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");

            for (int j = 0; j < (n -1) + (i-1); j++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            Console.WriteLine();
        }
        for (int i = 0; i < n + n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
            
        
    }
}


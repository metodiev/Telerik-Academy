using System;

//Input: 
//The input data is being read from the conso	le.
//On the only line in the console you are given an integer number N, showing the width of the map.
//The map’s height is always 2*N - 1.
//The input data will always be valid and in the format described. There is no need to check it explicitly.

//Output: 
//The output data must be printed on the console.
//You should print the whole map on the console. Use the symbol “*” 
//(asterisk) to mark Geeko’s path and “.” (dot) to illustrate the trees.

//Constraints:
//The number N is a positive integer between 2 and 79, inclusive.

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n   ; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(".");
            } 
            Console.Write("*");
            for (int p = 0; p < n-i-1; p++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }

        for (int i = n-2; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int p = 0; p < n - i - 1; p++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}

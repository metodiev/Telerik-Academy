using System;

//Input:
//The input data is being read from the console. 
//On the first input line there will be the digit B.
//On the second line you must read the number N.
//On each of the following N lines there is one positive integer number written – the consequent number,
//whose sum of binary digits B we are searching for.
//The input data will always be valid and in the format described. There is no need to check it explicitly.

//Output:
//The output must be printed on the console.
//In the output you must have N lines. Each line must have 1 integer number – 
//the number of digits B in the binary representation of the given consequent number.

//Constraints:
//•	Number N is a positive integer between 1 and 1000, inclusive.
//•	Each of the N numbers is a positive integer between 1 and 4 000 000 000, inclusive.
//•	The digit B will be only 0 or 1.

class BinaryDigitsCount
{
    static void Main()
    {
        byte b = byte.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int once = 0;
        int zeros = 0;
        if (b == 1)
        {
            for (int i = 0; i < N; i++)
            {
                once = 0;
                uint number = uint.Parse(Console.ReadLine());
                int p = Convert.ToString(number, 2).Length;
                int count = p;
                for (int j = 0; j <= count; j++)
                {
                    long mask = number & (1 << p);
                    long bit = mask >> p;
                    p--;
                    if (bit == 1)
                    {
                        ++once;
                    }
                }
                Console.WriteLine(once);
            }
        }

        if (b == 0)
        {
            for (int i = 0; i < N; i++)
            {
                zeros = 0;
                uint number = uint.Parse(Console.ReadLine());
                int p = Convert.ToString(number, 2).Length;
                int count = p;

                for (int j = 0; j <= count; j++)
                {
                    long mask = number & (1 << p);
                    long bit = mask >> p;
                    p--;
                    if (bit == 0)
                    {
                        ++zeros;
                    }
                }
                Console.WriteLine(zeros - 1);
            }
        }
    }
}
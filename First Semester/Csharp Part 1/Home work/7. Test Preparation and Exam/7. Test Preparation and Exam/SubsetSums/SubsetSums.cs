using System;

//Input:
//The input data is being read from the console. 
//On the first input line there will be the number S.
//On the second line you must read the number N.
//On each of the following N lines there will be one integer number written – all the numbers from the list.
//The input data will always be valid and in the format described. There is no need to check it explicitly.

//Output:
//The output must be printed on the console.
//On the only output line you must print the number of the non-empty subsets,
//which have sum of all its elements exactly S.

//Constraints:
//The number N is a positive integer between 1 and 16, inclusive.
//All of the N numbers are integer numbers and will be between -1 337 000 000 000 and 1 337 000 000 000, inclusive.
//The number S is an integer number between -21 392 000 000 000 and 21 392 000 000 000, inclusive.
//All of the N numbers will be distinct.


class CheckTheSum
{
    static void Main()
    {
        long S = long.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        long [] arr = new long[N];
        for (int i = 0; i < N; i++)
        {
            arr[i] = long.Parse(Console.ReadLine());
        }
        long [] compare = new long [N]; 
        int count = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
             if (compare[0]!= arr[i])
                {
                    if (arr[i] == S || arr[i] + arr[j] == S)
                    {
                        count += 1;
                        arr[i] = compare [0];
                    }
                }
            }    
        }
        Console.WriteLine(count);
    }
}


  



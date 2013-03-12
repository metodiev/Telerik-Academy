using System;

//Input:
//The input data is being read from the console.
//The number N is on the first input line.
//An integer between 1 and 10 is written on each of the next N lines (this is the number of the cat)
//The input data will always be valid and in the format described. There is no need to check it explicitly.

//Output:
//The output data must be printed on the console.
//On the only output line you must print the number of the cat, which has won the contest. 

//Constraints:
//The number N is a positive integer between 1 and 100 000, inclusive.
//The numbers of the cats for which the jury votes are positive integer numbers between 1 and 10, inclusive.


class MissCat
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int mark = 0;
        int firstCat = 0;
        int secondCat = 0;
        int thirdCat = 0;
        int fourthCat = 0;
        int fifthCat = 0;
        int sixCat = 0;
        int seventhCat = 0;
        int eightCat = 0;
        int nineCat = 0;
        int tenCat = 0;

        for (int i = 0; i < N; i++)
        {
            mark = int.Parse(Console.ReadLine());
            if (mark == 1)
            { firstCat++; }
            else if (mark == 2)
            { secondCat++; }
            else if (mark == 3)
            { thirdCat++; }
            else if (mark == 4)
            { fourthCat++; }
            else if (mark == 5)
            { fifthCat++; }
            else if (mark == 6)
            { sixCat++; }
            else if (mark == 7)
            { seventhCat++; }
            else if (mark == 8)
            { eightCat++; }
            else if (mark == 9)
            { nineCat++; }
            else if (mark == 10)
            { tenCat++; }
        }
        int [] arr1 = new int [10] {firstCat, secondCat, thirdCat, fourthCat, fifthCat,
                                    sixCat ,seventhCat, eightCat, nineCat, tenCat};
        int max = 0;
        int arrMax = 0;
        int arrMax2 = 0;
        int[] compare = new int[10];
        for (int i = 0; i <10; i++)
        {
            max = Math.Max(arr1[i],0);
            arrMax = Math.Max(arrMax, max);
            if (arrMax == arr1[i] )
            {
                arrMax2 = i;
                compare[i] = arrMax2;
            }

        }
        //Array.Sort(compare);
        //for (int i = 1; i < 10; i++)
        //{
        //    if (compare[0] == compare[arrMax2])
        //    {
        //        arrMax2 = compare[0];
        //    }
            
        //}
       Console.WriteLine(arrMax2+1);
    }
}


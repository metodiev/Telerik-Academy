using System;

//Input:
//The input data should be read from the console.
//You have an integer number N (always odd number) showing the height of the sand clock.
//The input data will always be valid and in the format described. There is no need to check it explicitly.

//Output:
//The output should be printed on the console.
//You should print the hourglass on the console. Each row can contain only the following characters: “.” 
//(dot) and “*” (asterisk). As shown in the example: the middle row must contain only one ‘*’ and all 
//other symbols must be “.”. Every next row (up or down from the middle one) must contain the 
//same number of ‘*’ as the previous one plus two. You should only use “.” to fill-in the rows, where necessary.

//Constraints:
//•	The number N will be a positive integer number between 3 and 101, inclusive.


class SandGlass
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int first = N;
        int second = N - (N - 1);
        int secondP = (N - 2);


        //first LIne
        for (int j = 0; j < first; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();


        //Second and Third Line
        for (int i = 0; i <= N-(3+i) ; second+=1,secondP-=2,i++)
        {
           for (int j = 0; j < second; j++)
			{
			    Console.Write("."); 
			}

           for (int p = 0; p < secondP; p++)
           {
               Console.Write("*");
           }

           for (int q = 0; q < second; q++)
           {
               Console.Write(".");
           }
           Console.WriteLine();
        }

        second -= 2;
        secondP += 4;
        for (int i = 0; i <N -(2 + i); second-=1,secondP+=2,i++)
        {
            for (int p = 0; p < second; p++)
            {
                Console.Write(".");
            }

            for (int j = 0; j < secondP; j++)
            {
                Console.Write("*");
            }

            for (int p = 0; p < second; p++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }

    }
}

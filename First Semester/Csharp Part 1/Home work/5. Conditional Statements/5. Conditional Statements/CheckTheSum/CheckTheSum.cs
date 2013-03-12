using System;

//We are given 5 integer numbers.
//Write a program that checks if the sum 
//of some subset of them is 0.
//Example: 3, -2, 1, 1, 8  1+1-2=0.

class CheckTheSum
{
    static void Main()
    {
        Console.WriteLine("Write five integer numbers");
        int [] numbers = new int [5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter {0} number", i);
            numbers [i] = int.Parse(Console.ReadLine());
        }

        bool isZero = false;

        foreach (int check in numbers)
        {
            if ((check <= 0))
            {
                isZero = true;
            }
        }

        bool zeroSum = false;

        if (isZero)
        {
            //Array.Sort(numbers);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int p = 0; p < 5; p++)
                    {
                        if (((numbers[i] + numbers[j] + numbers[p]) == 0))
                        {
                            zeroSum = true;
                        }
                    }                   
                }
            }

            Console.WriteLine("The sum of some numbers is 0: {0}", zeroSum );
        }
        else
        {
            Console.WriteLine("Sum of numbers is positive");
        }
    }
}


using System;
using System.Collections.Generic;

//Write a method that adds two positive integer numbers represented as arrays 
//of digits (each array element arr[i] contains a digit; the last digit 
//is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

class AddTwoInteger
{
    static void Main()
    {
        Console.WriteLine("Enter first integer positive number:");
        string firstNumber = Console.ReadLine();
        int[] first = new int[firstNumber.Length];

        for (int i = 0; i < first.Length; i++)
        {
            first[i] = firstNumber[i];
        }

        Array.Reverse(first);

        Console.WriteLine("Enter second integer positive number");
        string secondNumber = Console.ReadLine();
        int[] second = new int[secondNumber.Length];

        for (int i = 0; i < second.Length; i++)
        {
            second[i] = secondNumber[i];
        }

        Array.Reverse(second);

        int []arrnumber = Number(first, second);
        for (int i = 0; i < arrnumber.Length; i++)
        {
            Console.Write(arrnumber[i]);
        }
        
    }

    private static int []Number(int []first, int []second)
    {
        int min = Math.Min(first.Length, second.Length);
        int add = 0;
        List<int> max = new List<int>(Math.Max(first.Length, second.Length) + 1);

        for (int i = 0; i < min; i++)
        {
            max.Add((first[i] + second[i] + add) % 10);
            add = ((first[i] + second[i] + add) / 10) % 10;
        }

        if (first.Length > min)
        {
            for (int i = min; i < first.Length; i++)
            {
                max.Add((first[i] + add) % 10);
                add = ((first[i] + add) / 10) % 10;
            }
        }

        if (second.Length > min)
        {
            for (int i = min; i < second.Length; i++)
            {
                max.Add((second[i] + add) % 10);
                add = ((second[i] + add) / 10) % 10;
            }
        }

        if (add > 0)
        {
            max.Add(add);
        }

        return max.ToArray();
    }
}


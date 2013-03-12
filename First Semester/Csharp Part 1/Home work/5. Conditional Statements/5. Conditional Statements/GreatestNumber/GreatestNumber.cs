using System;

//Write a program that finds the greatest of given 5 variables.

class GreatestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers");
        int numbers;
        numbers = 5;
        int [] arr = new int [numbers];
        for (int i = 0; i < numbers; i++)
        {
            Console.WriteLine("Enter {0} number ", i);
            arr [i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        Console.WriteLine("Biggest number {0}", arr[4]);
    }
}


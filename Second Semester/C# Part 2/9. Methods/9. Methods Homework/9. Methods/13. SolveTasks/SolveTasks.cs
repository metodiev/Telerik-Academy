using System;

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
// Create appropriate methods.
// Provide a simple text-based menu for the user to choose which task to solve.
// Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

class SolveTasks
{
    static void ReverseDigits(decimal number)
    {
        string reverse = Convert.ToString(number);
        char[] reversedArray = reverse.ToCharArray();
        Array.Reverse(reversedArray);
        Console.WriteLine(reversedArray);
    }

    static void AverageOfSequence()
    {
        Console.WriteLine("Enter array length:");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];

        do
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter member {0}", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

        }while(arr.Length < 0);

        decimal average = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            average += arr[i];
        }

        average = average / arr.Length;
        Console.WriteLine("Average of sequence :{0}",average);
    }

    static void LinearEquation()
    {
        int a = 0;
        do
        {
            Console.WriteLine("Enter a coefficient а:");
            a = int.Parse(Console.ReadLine());

        }while(a == 0);
       // Console.WriteLine(a);
        Console.WriteLine("Enter coefficient b:");
        int b = int.Parse(Console.ReadLine());
        decimal x = 0;
        x = ((-b) / a);
        Console.WriteLine("{0:F3}",x);
    }

    static void Main()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Enter a number and reverse it's digits");
        Console.WriteLine("2. Enter array and calculate the average of a sequance of integers");
        Console.WriteLine("3. Solve linear equation");
        Console.WriteLine("Enter a choice:");

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: decimal number;
                do
                {
                    Console.WriteLine("Enter an integer number:");
                    number = decimal.Parse(Console.ReadLine());

                } while (number < 0);

                ReverseDigits(number);
                break;
            case 2: AverageOfSequence();
                break;
            case 3:
                LinearEquation();
                break;
            default:
                break;
        }
    }
}

using System;

//7. Write a program that gets a number n and after that gets 
//more n numbers and calculates and prints their sum

class SumSequenceOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers you wanna enter");
        int numbers;
        numbers = int.Parse(Console.ReadLine());
        int sumOfNumbers;
        sumOfNumbers = 0;
        for (int i = 0; i < numbers; i++)
        {
            Console.WriteLine("Enter {0} number", i);
            int number;
            number = int.Parse(Console.ReadLine());
            sumOfNumbers += number;
        }
        Console.WriteLine("Sum of numbers: {0}", sumOfNumbers);
    }
}

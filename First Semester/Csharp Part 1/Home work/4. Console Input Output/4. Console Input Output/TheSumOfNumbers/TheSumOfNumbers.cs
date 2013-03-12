using System;

//1. Write a program that reads 3 integer numbers from the console and prints their sum.


class TheSumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter firt number (integer):");
        int firstNumber;
        firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number (integer):");
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber;
        Console.WriteLine("Enter third number (integer):");
        thirdNumber = int.Parse(Console.ReadLine());

        int sumNumbers;
        sumNumbers = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("Sum of numbers: {0}", sumNumbers);
    }
}


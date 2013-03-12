using System;

//5.Write a program that gets two numbers from the console
//and prints the greater of them. Don’t use if statements.

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int firstNumber;
        firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber;
        secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Bigger number is: {0}", Math.Max(firstNumber, secondNumber));
    }
}


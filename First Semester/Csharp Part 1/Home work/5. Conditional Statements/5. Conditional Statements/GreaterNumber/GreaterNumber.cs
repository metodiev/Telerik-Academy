using System;

//Write an if statement that examines two integer 
//variables and exchanges their values if the first
//one is greater than the second one.

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

        if (firstNumber > secondNumber)
        {
            int temp;
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }
        Console.WriteLine("First number is {0}, second number is {1}", firstNumber, secondNumber);
    }
}


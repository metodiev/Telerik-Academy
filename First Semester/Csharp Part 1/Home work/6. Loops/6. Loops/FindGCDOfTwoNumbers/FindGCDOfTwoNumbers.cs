using System;

//Write a program that calculates the greatest common divisor (GCD) of
//given two numbers. Use the Euclidean algorithm (find it in Internet).

class FindGCDOfTwoNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
       int firstNumber;
        firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int secondNumber;
        secondNumber = int.Parse(Console.ReadLine());
        int gcd = 0 ;
        int temp;

        if (firstNumber == 0)
        {
            Console.WriteLine("GCD is second number : {0}", secondNumber);
        }
        else if (secondNumber == 0)
        {
            Console.WriteLine("GCD is first number: {0}", firstNumber);
        }
        else
        {
            while (firstNumber != 0 && secondNumber != 0)
            {
                temp = firstNumber;
                firstNumber = secondNumber % firstNumber;
                secondNumber = temp;
            }
            gcd = secondNumber;
            Console.WriteLine("GCD of two numbers {0}: ", gcd);
        }
    }
}


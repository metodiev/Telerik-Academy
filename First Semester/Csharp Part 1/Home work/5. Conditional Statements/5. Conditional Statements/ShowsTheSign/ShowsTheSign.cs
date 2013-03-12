using System;

//Write a program that shows the sign (+ or -)
//of the product of three real numbers without 
//calculating it. Use a sequence of if statements.

class ShowsTheSign
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers");
        Console.WriteLine("First number");
        decimal firstNumber;
        firstNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Second number");
        decimal secondNumber;
        secondNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Thrird number");
        decimal thirdNumber;
        thirdNumber = decimal.Parse(Console.ReadLine());

        int sign;
        sign =   Math.Sign(firstNumber) + Math.Sign(secondNumber) + Math.Sign(thirdNumber);
        Console.WriteLine(sign);

        if ((sign == 3) || (sign == -1))
        {
            Console.WriteLine("The sign of numbers: +");
        }
        else
        {
            Console.WriteLine("The sign of numbers: -");
        }
    }
}

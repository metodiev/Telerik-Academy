using System;

//Write a program that finds the biggest of three
//integers using nested if statements.

class BiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int firstNumber;
        firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber;
        secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Ener third number:");
        int thirdNumber;
        thirdNumber = int.Parse(Console.ReadLine());
        int biggerNumber = 0;
        int biggestNumber = 0;
        if ((firstNumber > secondNumber) && (firstNumber > thirdNumber))
        {
            biggerNumber = firstNumber;
            Console.WriteLine("Biggest number is {0}", biggerNumber);
        }
        else if ((secondNumber > thirdNumber) && (secondNumber > firstNumber))
        {
            biggerNumber = secondNumber;
            Console.WriteLine("Biggest number is {0}", biggerNumber);
        }
        else if ((thirdNumber > firstNumber) && (thirdNumber > secondNumber))
        {
            biggerNumber = thirdNumber;
             Console.WriteLine("Biggest number is {0}", biggerNumber);
        }
        else
        {
            Console.WriteLine("Some numbers are euqal");
            biggerNumber = Math.Max(secondNumber, thirdNumber);
            biggestNumber = Math.Max(biggerNumber, firstNumber);
            Console.WriteLine("Biggest number is {0}", biggestNumber);
        }
    }
}


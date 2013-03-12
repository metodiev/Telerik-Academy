using System;

//Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().


class BiggestIntegerNumber
{
    static int GetMax(int firstNumer, int secondNumber)
    {
        int temp = 0;

        if (firstNumer > secondNumber)
        {
            temp = firstNumer;
        }

        else if (secondNumber > firstNumer)
        {
            temp = secondNumber;
        }

        else
	    {
            Console.WriteLine("There are equal numbers {0}, {1}", firstNumer, secondNumber);
	    }

        return temp;

    }

    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int biggest = GetMax(firstNumber, secondNumber);
        Console.WriteLine("Biggest number is: {0}",GetMax(biggest, thirdNumber)); 
    }
}


using System;

class CompareFloatNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter two float numbers");
        float firstNumber;
        firstNumber = float.Parse(Console.ReadLine());
        float secondNumber;
        secondNumber = float.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            Console.WriteLine("Bigger number is first");
        }
        else if (secondNumber > firstNumber)
        {
            Console.WriteLine("Bigger number is second");
        }
        else
        {
            Console.WriteLine("Numbers are equal {0} = {1}", firstNumber, secondNumber);
        }
        Console.WriteLine("{0}, {1}", firstNumber, secondNumber);
    }
}


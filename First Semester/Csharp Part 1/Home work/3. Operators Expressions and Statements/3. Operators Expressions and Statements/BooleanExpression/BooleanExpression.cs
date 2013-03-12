using System;

class BooleanExpression
{
    static void Main()
    {
        Console.WriteLine("Enter integer number");
        int number;
        number = int.Parse(Console.ReadLine());

        bool expression = (((number % 7) == 0 && (number % 5) == 0));
        if (expression)
        {
            Console.WriteLine("divided by 7 and 5");
        }
        else
        {
            Console.WriteLine("Entered number can't be divided");
        }
    }
}


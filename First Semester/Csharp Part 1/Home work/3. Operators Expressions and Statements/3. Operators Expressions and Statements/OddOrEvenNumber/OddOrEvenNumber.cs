using System;

class OddOrEvenNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number;
        number = int.Parse(Console.ReadLine());

        if ((number % 2) == 0)
        {
            Console.WriteLine("Entered number {0}, is even", number);
        }
        else
        {
            Console.WriteLine("Entered number {0} is odd", number);
        }
    }
}


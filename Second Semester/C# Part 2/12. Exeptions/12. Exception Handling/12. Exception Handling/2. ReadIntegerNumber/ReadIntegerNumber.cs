//Write a method ReadNumber(int start, int end) that enters an integer number in
//given range [start…end]. If an invalid number or non-number text is entered, 
//the method should throw an exception. Using this method write a program that enters 10 numbers:
// a1, a2, … a10, such that 1 < a1 < … < a10 < 100


using System;

class ReadIntegerNumber
{
    private static void ReadNumbers(int start, int end, int num)
    {
        if (num < start || num > end)
        {
            throw new ArgumentOutOfRangeException();
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter start range:");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end range:");
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 10 members in start / end range:");

        try
        {
            for (int i = 0; i < 10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                ReadNumbers(start, end, number);
            }
        }

        catch (System.ArgumentNullException)
        {
            Console.WriteLine("Invalid number");
        }

        catch (System.FormatException)
        {
            Console.WriteLine("Invalid number");
        }

    }
}


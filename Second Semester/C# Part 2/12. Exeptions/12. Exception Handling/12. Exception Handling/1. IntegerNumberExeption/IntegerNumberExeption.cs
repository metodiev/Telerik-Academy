//Write a program that reads an integer number and calculates 
//and prints its square root. If the number is invalid or 
//negative, print "Invalid number". In all cases finally 
//print "Good bye". Use try-catch-finally.

using System;

class IntegerNumberExeption
{
    private static double NegativeNumber(int number)
    {
        if (number < 0)
        {
            throw new ArithmeticException();
        }
        return Math.Sqrt(number);
    }

    static void Main()
    {
        Console.WriteLine("Enter integer number:");
        try
        {
            int number = int.Parse(Console.ReadLine());
            double squareNumber;
            NegativeNumber(number);
            squareNumber = Math.Sqrt(number);
            Console.WriteLine(squareNumber);
                
        }

        catch (FormatException)
        {

            Console.WriteLine("Invalid number:");
        }

        catch (ArithmeticException)
        {
            Console.WriteLine("Invalid number");
        }
            
        finally
        {
            Console.WriteLine("Good bye");
        }

          
    }
}


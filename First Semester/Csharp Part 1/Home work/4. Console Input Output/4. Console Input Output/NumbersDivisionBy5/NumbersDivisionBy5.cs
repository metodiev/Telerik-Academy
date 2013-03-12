using System;

//4. Write a program that reads two positive integer numbers and 
//prints how many numbers p exist between them such that the
//reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.


class NumbersDivisionBy5
{
    static void Main()
    {
        Console.WriteLine("Enter two positive uint numbers");
        uint firstNumber;
        firstNumber = uint.Parse(Console.ReadLine());
        uint secondNumber;
        secondNumber = uint.Parse(Console.ReadLine());
        int counter = 0;

        if (firstNumber > secondNumber)
        {
            for (uint i = secondNumber; i <= firstNumber; i++)
            {
                if ((i % 5) == 0)
                {
                    ++counter;
                }
                
            }

            Console.WriteLine(
                "Between {0} and {1} there are: {2} numbers devide by 5", 
                secondNumber, firstNumber, counter
                );
        }

        else if (secondNumber > firstNumber)
        {
            for (uint i = firstNumber; i <= secondNumber; i++)
            {
                if ((i % 5) == 0)
                {
                    ++counter;
                }
                
            }

            Console.WriteLine(
                "Between {0} and {1} there are: {2} numbers devide by 5",
                firstNumber, secondNumber, counter 
                );
        }
        
        else
        {
            Console.WriteLine("Numbers are equal");
            bool condition = ((firstNumber % 5) == 0);
            Console.WriteLine("Numbers can be devided by 5: {0}", condition);
        }
    }
}


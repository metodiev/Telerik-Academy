using System;
using System.Text;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

class CheckBrackets
{
    static void Main()
    {
        Console.WriteLine("Enter expression with brackets:");
        string exression = Console.ReadLine();

        //string  exression = "((a+b)/5-d))";

        //check if the expression is correct
        int open = 0;
        int close = 0;
        for (int i = 0; i < exression.Length; i++)
        {
            if (exression[i] == '(')
            {
                open++;
            }

            else if (exression[i] == ')')
            {
                close++;
            }
        }

        bool isCorrect = false;

        if (open == close)
        {
            isCorrect = true;
            Console.WriteLine("Entered expression is correct: {0}", isCorrect);
            
        }

        else
        {
            Console.WriteLine("Entered expression is correct: {0}", isCorrect);
        }
    }
}


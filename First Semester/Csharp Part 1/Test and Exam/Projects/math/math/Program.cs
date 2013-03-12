using System;

//Input:
//The input data is being read from the console.
//The input consists of exactly 3 lines. In each line you consequently enter the variables N, M and P.
//The separator between the integer and the fractional part of the number is “.” (dot).
//The number of digits that follow the decimal point will not be more than 6.
//The input data will always be valid and in the format described. There is no need to check it explicitly.

//Output:
//The output data must be printed on the console.
//There must be only one line, showing the result from the mathematical expression.
//The result must show exactly 6 digits after the “.” (decimal point).

//Constraints:
//The numbers N, M and P are fractional numbers.
//N, M and P will be between -10 000 000 and 10 000 000, inclusive.
//The numbers M and P will always have values other than 0
//It is guaranteed that none of the combinations of the numbers N, M and P will lead to dividing by zero.

class MathExpression
{
    static void Main()
    {
        decimal N = decimal.Parse(Console.ReadLine());
        decimal M = decimal.Parse(Console.ReadLine());
        decimal P = decimal.Parse(Console.ReadLine());

        decimal expression;
        decimal nSquare = N * N;
        int mod = (((int)M) % 180);
        decimal sin = (decimal)Math.Sin(mod);
        expression = ((nSquare + (1 / M * P) + 1337) / (N - (128.523123123m * P))) + sin;

        Console.WriteLine("{0:F6}", expression);
    }
}


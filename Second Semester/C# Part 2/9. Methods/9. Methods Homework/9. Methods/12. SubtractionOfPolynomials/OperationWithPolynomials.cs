using System;
//Write a method that adds two polynomials. 
//Represent them as arrays of their coefficients as in the example below:
//        x2 + 5 = 1x2 + 0x + 5 
//Extend the program to support also subtraction and multiplication of polynomials.

class Polynomials
{
    static void SumOfPolinomials(decimal[] first, decimal[] second, decimal[] sum)
    {
        int min = 0;
        int small = 0;

        if (first.Length > second.Length)
        {
            min = second.Length;
            small = 2;
        }
        else if (second.Length > first.Length)
        {
            min = first.Length;
            small = 1;
        }

        for (int i = 0; i < min; i++)
        {
            sum[i] = first[i] + second[i];
        }

        for (int i = min; i < sum.Length; i++)
        {
            if (small == 1)
            {
                sum[i] = second[i];
            }
            else
            {
                sum[i] = first[i];
            }
        }
    }

    static void SubstractionOfPolinomials(decimal[] first, decimal[] second, decimal[] sum)
    {
        int min = 0;
        int small = 0;

        if (first.Length > second.Length)
        {
            min = second.Length;
            small = 2;
        }
        else if ( second.Length > first.Length)
        {
            min = first.Length;
            small = 1;
        }

        for (int i = 0; i < min; i++)
        {
            sum[i] = first[i] - second[i];
        }

        for (int i = min; i < sum.Length; i++)
        {
            if (small == 1)
            {
                sum[i] = second[i];
            }

            else
            {
                sum[i] = first[i];
            }
        }
    }


    static void MultiplyPolinomials(decimal[] first, decimal[] second, decimal[]sum)
    {
       
        for (int i = 0; i <sum.Length; i++)
        {
           sum[i] = 0;
        }

        for (int i = 0; i < first.Length; i++)
        {
            for (int j = 0; j < second.Length; j++)
            {
                int position = i + j;
               sum[position] += (first[i] * second[j]);
            }
        }
    }

    static void PrintPolinomial(decimal[] polinomial)
    {
        for (int i = polinomial.Length - 1; i >= 0; i--)
        {
            if (polinomial[i] != 0 && i != 0)
            {
                if (polinomial[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} +", i, polinomial[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, polinomial[i]);
                }
            }

            else if (i == 0)
            {
                Console.Write("{0}", polinomial[i]);
            }
        }

        Console.WriteLine();
    }

    static void Main()
    {
        decimal[] first = {5,6,7,8 };
        PrintPolinomial(first);

        decimal[] second = { 5, 6, 7, 8 };
        PrintPolinomial(second);

        int maxLenght = 0;

        if (first.Length > second.Length)
        {
            maxLenght = first.Length;
        }

        else if (second.Length > first.Length)
        {
            maxLenght = second.Length;
        }

        decimal[]sum = new decimal[maxLenght];
        SumOfPolinomials(first, second, sum);

        Console.Write("Sum of two polinomials:");
        PrintPolinomial(sum);

        SubstractionOfPolinomials(first, second,sum);
        Console.Write("Substraction:");
        PrintPolinomial(sum);

        decimal[] multiply = new decimal[first.Length + second.Length];
        MultiplyPolinomials(first, second, multiply);
        Console.Write("Multiplication:");
        PrintPolinomial(multiply);
    }
}


using System;
//Write a method that adds two polynomials. 
//Represent them as arrays of their coefficients as in the example below:
//        x2 + 5 = 1x2 + 0x + 5 

class Polynomials
{
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


    static void SumOfPolinomials(decimal[] first, decimal[] second, decimal[] sum)
    {
        int min = 0;
        int small = 0;

        if (first.Length > second.Length)
        {
            min = second.Length;
            small = 2;
        }
        else if(first.Length < second.Length)
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
  
   
    static void Main()
    {
        decimal[] first = {1, 6, 3, 5};
        Console.Write("First polinomial:");
        PrintPolinomial(first);

        decimal[] second = {1, 6, 3, 5};
        Console.Write("Second polinomial:");
        PrintPolinomial(second);

        int maxLenght = 0;
        if (first.Length > second.Length)
        {
            maxLenght = first.Length;
        }

        else
        {
            maxLenght = second.Length;
        }

        decimal[] result = new decimal[maxLenght];
        Console.WriteLine();

        SumOfPolinomials(first, second, result);

        Console.Write("Sum of two polinomial:  ");
        PrintPolinomial(result);

    }
}

using System;

//6. Write a program that reads the coefficients a,
//b and c of a quadratic equation ax2+bx+c=0 and
//solves it (prints its real roots).


class QuadraticEquation
{
    static void Main()
    {

        Console.WriteLine("Enter first coefficient a:");
        decimal firstCoef;
        firstCoef = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter second coefficient b:");
        decimal secondCoef;
        secondCoef = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter third coefficient c:");
        decimal thirdCoef;
        thirdCoef = decimal.Parse(Console.ReadLine());
        decimal discriminant;
        discriminant = ((secondCoef * secondCoef) - (4 * firstCoef * thirdCoef)); 
        //D= b^2 + (4*a*c)
        Console.WriteLine("Discriminant: D = {0}", discriminant);

        if (discriminant == 0)
        {
           decimal doubleRoot = (-(secondCoef) / (2 * firstCoef));
            Console.WriteLine("Root: {0}", doubleRoot);
        }

        else if (discriminant > 0)
        {
            decimal firstRoot ;
            //x= -b + sqrt(d)/2*a
            firstRoot = ((-secondCoef) + (decimal)Math.Sqrt((double)discriminant))/ (2 * firstCoef);
            Console.WriteLine("First root is: {0}", firstRoot);
            decimal secondRoot;
            secondRoot = (((-secondCoef) - (decimal)Math.Sqrt((double)discriminant))/ (2 * firstCoef));
            Console.WriteLine("Second root: {0}", secondRoot);
        }

        else 
        {
            Console.WriteLine(
                "Discriminant is negative and roots are not real (complex roots) "
                );
        }
    }
}


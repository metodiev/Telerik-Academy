using System;

//Write a program that enters the coefficients a, b and c of a quadratic equation
//a*x2 + b*x + c = 0


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
            Console.WriteLine("Discriminant: D=0 - double roots:");
            decimal doubleRoot = (-(secondCoef) / (2 * firstCoef));
            Console.WriteLine("Roots: {0}", doubleRoot);
        }

        else if (discriminant > 0)
        {
            decimal firstRoot;
            //x= -b + sqrt(d)/2*a
            firstRoot = ((-secondCoef) + (decimal)Math.Sqrt((double)discriminant)) / (2 * firstCoef);
            Console.WriteLine("First root is: {0}", firstRoot);
            decimal secondRoot;
            secondRoot = (((-secondCoef) - (decimal)Math.Sqrt((double)discriminant)) / (2 * firstCoef));
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


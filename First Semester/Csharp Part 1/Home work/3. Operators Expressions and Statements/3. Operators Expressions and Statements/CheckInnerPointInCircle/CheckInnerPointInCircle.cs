using System;

class CheckInnerPointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter x:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter y:");
        int y = int.Parse(Console.ReadLine());
        double expressionMath;
        expressionMath = Math.Sqrt(((x * x) + (y * y)));

        bool expression = (expressionMath <= 5);
        if (expression)
        {
            Console.WriteLine("Point (x, y) are in circle K(0, 5)");
        }
        else
        {
            Console.WriteLine("Point (x, y) are out of circle K(0, 5)");
        }
    }
}


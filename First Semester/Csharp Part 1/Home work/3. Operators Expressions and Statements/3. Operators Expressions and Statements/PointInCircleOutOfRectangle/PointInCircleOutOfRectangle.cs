using System;

class PointInCircleOutOfRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter x:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter y point:");
        int y = int.Parse(Console.ReadLine());
        int rectangleX;
        int rectangleY;
        rectangleX = x - 1;
        rectangleY = y - 1;

        double expressionMath;
        expressionMath = Math.Sqrt(((x * x) + (y * y)));

        bool expression = (expressionMath <= 5);
        if (expression)
        {
            Console.WriteLine("Point (x, y) are in circle K(0, 5)");
        }
        else
        {
            Console.WriteLine("Point (x, y) are out of circle K(1,1), 3");
        }

        bool rectanglExpression;
        rectanglExpression = ( (rectangleX <= 5) && (rectangleX >= -1) && (rectangleY <= 1) && (rectangleY >= -1) );
        if (rectanglExpression)
        {
            Console.WriteLine("The point (x, y) are in rectangle");
        }
        else
        {
            Console.WriteLine("The point (x, y) are not in rectangle");
        }
    }
}


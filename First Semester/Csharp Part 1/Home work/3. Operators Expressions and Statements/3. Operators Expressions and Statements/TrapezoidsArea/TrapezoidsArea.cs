using System;

class TrapezoidsArea
{
    static void Main()
    {
        Console.WriteLine("Enter first length of trapezoid");
        int firstLength;
        firstLength = int.Parse(Console.ReadLine());       
        Console.WriteLine("Enter second side of trapezoid");
        int secondLengths;
        secondLengths= int.Parse(Console.ReadLine());
        Console.WriteLine("Enter h of trapeziod");
        int high;
        high = int.Parse(Console.ReadLine());

        int area;
        area = ((firstLength + secondLengths) / 2) * high;
        //S = (a + b) / 2 * h.
        Console.WriteLine("Area of trapezoid is {0}", area);
    }
}


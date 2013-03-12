using System;

//2. Write a program that reads the radius r of a circle and prints its perimeter and area.


class PerimeterAndAreaOfCircle
{
    static void Main()
    {
        Console.WriteLine("Enter radius of circle r:");
        int raduis;
        raduis = int.Parse(Console.ReadLine());
        double area;
        area = Math.PI * raduis * raduis;
        Console.WriteLine("Area of circle is: {0}", area);
        double perimeter;
        perimeter = 2 * Math.PI * raduis;
        Console.WriteLine("Perimeter of circle is: {0}", perimeter);
    }
}

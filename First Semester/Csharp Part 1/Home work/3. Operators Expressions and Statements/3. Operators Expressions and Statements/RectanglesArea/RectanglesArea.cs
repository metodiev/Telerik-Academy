using System;

class RectanglesArea
{
    static void Main()
    {
        Console.WriteLine("Ener width:");
        int width;
        width = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter height:");
        int height;
        height = int.Parse(Console.ReadLine());

        int rectangleArea = (width * height);
        Console.WriteLine("Recranle's area is {0}", rectangleArea);
    }
}


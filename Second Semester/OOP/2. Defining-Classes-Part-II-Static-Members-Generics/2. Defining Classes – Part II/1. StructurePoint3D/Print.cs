using System;

class Points3D
{
    static void Main()
    {
        // Initialize
        Point3D point = new Point3D();
        point.x = int.Parse(Console.ReadLine());
        point.y = int.Parse(Console.ReadLine());
        point.z = int.Parse(Console.ReadLine());

        //print Points
        Console.WriteLine(point.ToString());
       
    }
}

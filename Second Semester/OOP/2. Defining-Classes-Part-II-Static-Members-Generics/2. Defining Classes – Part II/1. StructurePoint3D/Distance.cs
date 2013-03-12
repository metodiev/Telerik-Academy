//
//Write a static class with a static method to calculate the distance between two points in the 3D space.
using System;

static class Distance
{
    //Static method to calculate the distance between two points
    public static double DistanceBetweenPoints()
    {
       Point3D points = new Point3D();

       double distance = Math.Sqrt(points.x * points.x + points.y * points.y + points.z * points.z);
       return distance;
        
    }
}


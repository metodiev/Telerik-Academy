//
//Create a class Path to hold a sequence of points in the 3D space. 
//Create a static class PathStorage with static methods to save and
//load paths from a text file. Use a file format of your choice.

using System;
using System.Collections.Generic;

public class Path
{
    // field to hold a sequence of points in the 3D space
    public  List<Point3D> sequenceOfPoints = new List<Point3D>();

    //constructor
    public Path(List<Point3D> sequence)
    {
        this.sequenceOfPoints = sequence;
    }

    //property Paths
    public List<Point3D> Paths
    {
        get { return this.sequenceOfPoints; }
    }

    //method to add point
    public void AddPoint(Point3D point)
    {
        sequenceOfPoints.Add(point);
    }

    public void ClearPath()
    {
        sequenceOfPoints.Clear();
    }
}
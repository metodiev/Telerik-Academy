//Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.
using System;
using System.Collections.Generic;
using System.IO;

//create a static class PathStorage

static class PathStorage
{
    //example for file 
    public static void CreateFile()
    {
        using (StreamWriter writer = new StreamWriter("file.txt"))
        {
            writer.WriteLine("55555");

        }
    }
    
    //static method to save path from txt file
    static void SavePath()
    {
        // Create a reference to the current directory.
        DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory);
        // Create an array representing the files in the current directory.
        DirectoryInfo[] fi = di.GetDirectories();
       
        Console.WriteLine("The following files exist in the current directory:");
        // Print out the names of the files in the current directory.
        foreach (DirectoryInfo fiTemp in fi)
            Console.WriteLine(fiTemp.Name);
    }
}


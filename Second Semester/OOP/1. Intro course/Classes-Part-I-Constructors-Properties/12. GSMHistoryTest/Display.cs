﻿public class Display
{
    //fields for Display class
    private int size;
    private int numbersOfColors;

    //Default constructor
    public Display()
    {
        this.size = 0;
        this.numbersOfColors = 0;
    }

    // Constructor with parameters
    public Display(int dispSize, int colors)
    {
        this.size = dispSize;
        this.numbersOfColors = colors;
    }

    //property Size
    public int Size
    {
        get { return this.size; }
        set {

            this.size = value; 
            if (this.size <= 0 )
            {
                System.Console.WriteLine("Wrong size");
                throw new System.ArgumentException("Parameter cannot be  smaller than zero");
            }
        }
    }

    //property NumberOfColors
    public int NumberOfColors
    {
        get { return this.numbersOfColors; }
        set {
                
                this.numbersOfColors = value; 
                if (this.numbersOfColors <= 0)
                {      
                     System.Console.WriteLine("Wrong colors numbers");
                    throw new System.ArgumentException("Parameter cannot be null or smaller than zero");
                }
        }
    }
}

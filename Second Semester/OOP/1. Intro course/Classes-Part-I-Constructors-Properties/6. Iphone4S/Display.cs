public class Display
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
            if (this.size > 0 )
            {
                this.size = value; 
            }
            
        }
    }

    //property NumberOfColors
    public int NumberOfColors
    {
        get { return this.numbersOfColors; }
        set {
                if (this.numbersOfColors > 0)
                {
                     this.numbersOfColors = value; 
                }
        }
    }
}


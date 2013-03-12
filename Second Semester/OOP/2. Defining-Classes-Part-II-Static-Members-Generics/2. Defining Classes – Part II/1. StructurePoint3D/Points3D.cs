//
//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the
//Euclidian 3D space. Implement the ToString() to enable printing a 3D point.

// struct declaration 
public struct Point3D
{
    //struct fields
    public int x{ get; set; }
    public int y{ get; set; }
    public int z{ get; set; }


    //constructor with parameters 
    public Point3D(int x, int y, int z)
        : this()
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    //property x
    public int X
    {
        get { return this.x; }
        set { this.x = value; }

    }

    //property Y
    public int Y
    {
        get { return this.y; }
        set { this.y = value; }
    }

    //property z 
    public int Z
    {
        get { return this.z; }
        set { this.z = value; }
    }

    //Add a private static read-only field to hold the start 
    //of the coordinate system – the point O{0, 0, 0}. 
    public static readonly Point3D opoint = new Point3D(0, 0, 0);



    //Add a static property to return the point O.
    public static Point3D Opoint()
    {
        return opoint;
    }
   

    //override method for dispay information about 3DPoints
    public override string ToString()
    {    
        return string.Format("Point X: {0}\nPoint Y: {1}\nPoint Z: {2}", this.x, this.y, this.z);       
    }
        
}



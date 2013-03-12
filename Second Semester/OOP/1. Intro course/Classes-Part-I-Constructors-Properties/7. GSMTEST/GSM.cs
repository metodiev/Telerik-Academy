public class GSM
{
    // Create a new instance of Battery
    Battery battery = new Battery("Li-on", 500, 150, Battery.BatteryType.Lion);
   
    // Create a new instance Display
    Display display = new Display(5, 6500);

    //Define static field Iphone4S
    public static string iphone4S;

    //Define static property for Iphone4S
    public static string Iphone4S
    {
        get { return iphone4S; }
        set {
                iphone4S = value;
                                                                                                    
                if (iphone4S == null || iphone4S == string.Empty)
                {
                    System.Console.WriteLine("Wrong Model");
                    throw new System.ArgumentException("Parameter cannot be null");
                }      
        }
    }

    //GSM fields
    private string model;
    private string manufacturer;
    private decimal price;
    private string owner;

    // Default constructor
    public GSM()
    {
        this.model = null;
        this.manufacturer = null;
        this.price = 0M;
        this.owner = null;
    }

    // Constructor with parameters
    public GSM(string model, string manufacturer, decimal price, string owner)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
    }

    //property Model
    public string Model
    {
        get { return this.model; }
        set {

                this.model = value;

                if (this.model == null || this.model == "" || this.model == string.Empty)
                {
                    System.Console.WriteLine("Wrong Model");
                    throw new System.ArgumentException("Parameter cannot be null");
                    
                }
        }
    }

    //property Manufacturer
    public string Manufacturer
    {
        get { return this.manufacturer; }
        set {    
                this.manufacturer = value;

                if (this.manufacturer == null || this.manufacturer == "" || this.manufacturer == " " || this.manufacturer == string.Empty)
                {
                    System.Console.WriteLine("Wrong Manufacturer");
                    throw new System.ArgumentException("Parameter cannot be null ");
                }    
            }
    }

    //property Price
    public decimal Price
    {
        get { return this.price; }
        set {
               this.price = value;

                if (this.price <= 0 )
                {
                    System.Console.WriteLine("!Wrong price");
                    throw new System.ArgumentException("Parameter cannot be smaller than zero or zero");                     
                }
        }
    }

    //property Owner
    public string Owner
    {
        get { return this.owner; }
        set {
                this.owner = value;

                if (owner == null || owner == string.Empty)
                {
                    System.Console.WriteLine("The Owner cannot be empty");
                    throw new System.ArgumentException("Parameter cannot be null");         
                }
                    

        }
    }

    //override method for dispay information about GSM
    public override string ToString()
    {    
        return string.Format("Model: {0}\nManufacturer: {1}\nPrice: {2}\nOwner: {3}", this.model, this.manufacturer, this.price, this.owner);       
    }
}


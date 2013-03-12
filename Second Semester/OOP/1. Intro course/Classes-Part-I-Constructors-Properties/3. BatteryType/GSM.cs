public class GSM
{
    // Create a new instance of Battery
    Battery battery = new Battery("Li-on", 500, 150, Battery.BatteryType.Lion);
   
    // Create a new instance Display
    Display display = new Display(5, 6500);

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

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set { this.manufacturer = value; }
    }

    public decimal Price
    {
        get { return this.price; }
        set { this.price = value; }
    }

    public string Owner
    {
        get { return this.owner; }
        set { this.owner = value; }
    }
}


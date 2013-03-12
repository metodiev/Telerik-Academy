public class Battery
{
    //fileds for Battery class
    private string model;
    private int hoursIdle;
    private int hoursTalk;

    //new batteryType field 
    private BatteryType battery;

   //enumeration BatteryType
   public enum BatteryType
    {      
       Lion,
       NiMH,
       LiPoly,
       NiCd,
       NiC, 
   };
  
    
    //Default constructor
    public Battery()
    {
        this.battery = BatteryType.Lion;
        this.model = null;
        this.hoursIdle = 0;
        this.hoursTalk = 0;
    }

    // Constructor with parameters
    public Battery(string phoneModel, int talk, int idle, BatteryType batteryType)
    {
        this.model = phoneModel;
        this.hoursIdle = idle;
        this.hoursTalk = talk;
        this.battery = batteryType;
    }

    //Property Model
   public string Model
    {
        get { return this.model; }
        set
        {
            this.model = value;

            if (this.model == null || this.model == string.Empty)
            {
                System.Console.WriteLine("Incorrect Model");
                throw new System.ArgumentException("Parameter cannot be null");
            }

        }
    }

    //Property HoursIdle
    public int HoursIdle
    {
        get { return this.HoursIdle; }
        set
        {
            this.hoursIdle = value;

            if (this.hoursIdle <= 0)
            {
                System.Console.WriteLine("Incorrect Value:");
                throw new System.ArgumentException("Parameter cannot be zero or smaller ");
            }
        }
    }

    //Property HoursTalk
    public int HoursTalk
    {
        get { return this.hoursTalk; }
        set
        {
            this.hoursTalk = value;
            if (this.hoursTalk <= 0)
            {
                System.Console.WriteLine("Incorrect Value:");
                throw new System.ArgumentException("Parameter cannot be  smaller than zero");
            }
           
        }
    }
}


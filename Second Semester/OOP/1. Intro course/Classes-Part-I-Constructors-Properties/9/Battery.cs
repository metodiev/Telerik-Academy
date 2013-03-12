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
            if (model != null)
            {
                this.model = value;
            }

            else
            {

                System.Console.WriteLine("Incorrect value ");
            }
        }
    }

    //Property HoursIdle
    public int HoursIdle
    {
        get { return this.HoursIdle; }
        set
        {

            if (this.hoursIdle != 0 && this.hoursIdle != null)
            {
                this.hoursIdle = value;
            }

            else
            {
                System.Console.WriteLine("Incorrect Value:");
            }

        }
    }

    //Property HoursTalk
    public int HoursTalk
    {
        get { return this.hoursTalk; }
        set
        {

            if (this.hoursTalk != 0 && this.hoursTalk > 0)
            {
                this.hoursTalk = value;
            }

            else
            {
                System.Console.WriteLine("Incorrect Value:");
            }
        }
    }
}


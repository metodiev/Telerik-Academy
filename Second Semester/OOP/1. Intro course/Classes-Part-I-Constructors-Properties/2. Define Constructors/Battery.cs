 public class Battery
{
     //fields for Battery class
    private string model;
    private int hoursIdle;
    private int hoursTalk;

    //Default constructor
   public Battery()
    {
        this.model = null;
        this.hoursIdle = 0;
        this.hoursTalk = 0;
    }

    // Constructor with parameters
   public Battery(string phoneModel, int talk, int idel)
    {
        this.model = phoneModel;
        this.hoursIdle = idel;
        this.hoursTalk = talk;
    }

     //Property Model
    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

     //property HoursIdle
    public int HoursIdle
    {
        get { return this.HoursIdle; }
        set { this.hoursIdle = value; }
    }

     //Property HoursTalk
    public int HoursTalk
    {
        get { return this.hoursTalk; }
        set { this.hoursTalk = value; }
    }
}


using System;

public class Call
{
    // fields for Call class
    private DateTime date =  new DateTime();
    private double time;
    private string dialNumber;
    private double duration;

    //Default Constructor
    public Call()
    {
        this.date = DateTime.Today;
        this.time = DateTime.Now.Second;
        this.dialNumber = null;
        this.duration = 0d;
    }

    //constructor with Parameters
    public Call(DateTime currentDate, double currentTime, string number, double seconds)
    {
        this.date = currentDate;
        this.time = currentTime;
        this.dialNumber = number;
        this.duration = seconds;
    }

    //property Date
    public DateTime Date
    {
        get { return this.date; }
        set { this.date = value; }
    }

    //property time
    public double Time
    {
        get { return this.time; }
        set { this.time = value; }
    }

    //property DialNumber
    public string DialNumber
    {
        get { return this.dialNumber;}
        set { this.dialNumber = value; }
    }

    //property seconds
    public double Duration
    {
        get { return this.duration;}
        set { this.duration = value; }
    }
}


using System;
using System.Data;
using System.Collections.Generic;

public class Call
{
    //fields for Call class
    private string date;
    private string  time;
    private string dialedNumber;
    private List<Call> calls = new List<Call>();
    private string duration = TimeSpan.TicksPerSecond.ToString();
    
     // Default constructor
    public Call()
    {
        this.date = null;
        this.time = null;
        this.dialedNumber = null;
        this.calls = null;
        this.duration = null;
    }

    // Constructor with parameters
    public Call(string callDate, string callTime, string callNumbers, string duration)
    {
        this.date = callDate;
        this.time = callTime;
        this.dialedNumber = callNumbers;
        this.duration = duration;
    }

    //Property Date
    public string Date
    {
        get { return this.date; }
        set { this.date = value; }
    }

    //property Time
    public string Time
    {
        get {return this.time; }
        set{ this.time = value; }
    }

    //Property DialedNumber
    public string DialedNumber
    {
        get { return this.dialedNumber; }
        set { this.dialedNumber = value;}
    }

    //Property Duration
    public string Duration
    {
        get { return this.duration; }
        set { this.duration = value; }
    }
}


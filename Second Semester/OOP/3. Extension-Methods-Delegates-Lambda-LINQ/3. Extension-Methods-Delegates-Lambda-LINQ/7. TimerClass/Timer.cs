//Using delegates write a class Timer that has can 
//execute certain method at each t seconds.


using System;
using System.Diagnostics;


public delegate void Timer (int second);

public class Timer
{
        public static void Time(int seconds)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true)
            {
                if (sw.ElapsedMilliseconds == seconds*1000)
                {
                    sw.Restart();
                }
            }

        }
} 


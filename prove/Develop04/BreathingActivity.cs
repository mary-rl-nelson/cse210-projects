using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading;


public class BreathingActivity : Activity
{
    private List<string> _breathingStrings = new List<string>();
    private DateTime _startTime;
    private DateTime _endTime;
    


    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        _breathingStrings.Add("Breathe In");
        _breathingStrings.Add(".");
        _breathingStrings.Add(".");
        _breathingStrings.Add(".");
        _breathingStrings.Add("Breathe Out");
        _breathingStrings.Add(".");
        _breathingStrings.Add(".");
        _breathingStrings.Add(".");
    }    

    public void Timer()
    {
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);    
    }

    public void RunBreathing()
    {
        Timer();
        int i = 0;

        while(DateTime.Now < _endTime)
        {
            string s = _breathingStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            for (int j = 0; j < s.Length; j++)
            {
                Console.Write("\b \b");
            }


            i++;
            if (i >= _breathingStrings.Count)
            {
                i=0;
            }
        }
    }

}
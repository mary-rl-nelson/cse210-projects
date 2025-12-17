using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("09 Nov 2026", 20, 2));
        activities.Add(new Cycling("09 Dec 2025", 10, 12));
        activities.Add(new Swimming("01 Jan 2026", 90, 40));

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetActivitySummary());
        }
    }
}

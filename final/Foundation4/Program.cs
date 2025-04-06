using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = Activitymaker.CreateActivity();

        foreach (var activity in activities)
        {
            {
                Console.WriteLine($"Summary: {activity.GetSummary()}");
                Console.WriteLine("");
            }
        }
    }
}
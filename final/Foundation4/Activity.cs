using System;
using System.Collections.Generic;

abstract class Activity {
    private string Date;
    private int Minutes;

    public Activity(string date, int minutes) {
        this.Date = date;
        this.Minutes = minutes;
    }

    public string GetDate() => Date;
    public int GetMinutes() => Minutes;

    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    public virtual string GetSummary() {
        return $"{Date} | Activity: {this.GetType().Name} ({Minutes} min)\nDistance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
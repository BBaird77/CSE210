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
        return "Summary.";
    }
}
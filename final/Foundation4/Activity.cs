using System;
using System.Collections.Generic;

abstract class Activity {
    private string Date;
    private int Minutes;

    public Activity(string date, int minutes) {
        this.Date = date;
        this.Minutes = minutes;
    }
}
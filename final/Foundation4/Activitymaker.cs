using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

public class Activitymaker {
    public static List<Activity> CreateActivity() {
        Running run = new Running("2025-04-05", 30, 3.0);

        Cycling cycle = new Cycling("2025-04-05", 45, 12.0);

        Swimming swim = new Swimming("2025-04-05", 30, 120);

        return new List<Activity> { run, cycle, swim };
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Breathing: Activity
{
    public override void RunActivity()
    {
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.Write("Breathe in... ");
            Countdown(5);
            Console.Write("Breathe out... ");
            Countdown(5);
            elapsed += 10;
        }
    }
    public override string GetDescription() => "This activity will help you relax by guiding you through deep breathing.";
}

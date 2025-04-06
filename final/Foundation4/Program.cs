using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("2025-04-05", 30, 3.0);
        Console.WriteLine($"Date: {run.GetDate()}");
        Console.WriteLine($"Duration: {run.GetMinutes()} minutes");
        Console.WriteLine($"Distance: {run.GetDistance()} miles");
        Console.WriteLine($"Speed: {run.GetSpeed()} mph");
        Console.WriteLine($"Pace: {run.GetPace()} min/mile");
        Console.WriteLine($"Summary: {run.GetSummary()}");

        Cycling cycle = new Cycling("2025-04-05", 45, 12.0);
        Console.WriteLine($"Date: {cycle.GetDate()}");
        Console.WriteLine($"Duration: {cycle.GetMinutes()} minutes");
        Console.WriteLine($"Distance: {cycle.GetDistance()} miles");
        Console.WriteLine($"Speed: {cycle.GetSpeed()} mph");
        Console.WriteLine($"Pace: {cycle.GetPace()} min/mile");
        Console.WriteLine($"Summary: {cycle.GetSummary()}");
    }
}
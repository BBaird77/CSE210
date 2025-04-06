using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("2025-04-05", 30, 3.0);
        Console.WriteLine($"Summary: {run.GetSummary()}");
        Console.WriteLine("");

        Cycling cycle = new Cycling("2025-04-05", 45, 12.0);
        Console.WriteLine($"Summary: {cycle.GetSummary()}");
        Console.WriteLine("");

        Swimming swim = new Swimming("2025-04-05", 30, 120);
        Console.WriteLine($"Summary: {swim.GetSummary()}");
        Console.WriteLine("");
    }
}
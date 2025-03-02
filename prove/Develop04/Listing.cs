using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Listing: Activity
{
    public static string[] Prompt =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

     public override void RunActivity()
    {
        Random rnd = new();
        Console.WriteLine(Prompt[rnd.Next(Prompt.Length)]);
        Countdown(5);
        Console.WriteLine("Start listing items: (press Enter after each item, blank line to stop)");
        int count = 0;
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            if (Console.ReadLine().Trim() == "") break;
            count++;
        }
        Console.WriteLine($"You listed {count} items!");
    }

    public override string GetDescription() => "This activity helps you reflect on positive aspects of your life by listing them.";
}
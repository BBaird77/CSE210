using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

abstract class Activity
{
    public int Duration;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting up the {GetType().Name} Activity...");
        Console.WriteLine(GetDescription());
        Console.Write("Enter the chosen duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to start!");
        Countdown(5);
        RunActivity();
        End();
    }

    public abstract string GetDescription();
    public abstract void RunActivity();
    private void End()
    {
        Console.WriteLine("Great job on completing the activity!");
        Console.WriteLine($"You completed the {GetType().Name} activity for a total of {Duration} seconds.");
        Countdown(5);
    }
    public void Countdown(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("\b \b");
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write(i+1);
            
        }
        Console.WriteLine();
    }
}

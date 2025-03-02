using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Prompt> Prompt = new List<Prompt>
        {
            new Prompt(
                "Think of a time when you stood up for someone else."),
            new Prompt(
                "Think of a time when you did something really difficult."),
            new Prompt(
                "Think of a time when you helped someone in need."),
            new Prompt(
                "Think of a time when you did something truly selfless.")
        };

        Random random = new Random();
        Prompt Prompt = Prompt[random.Next(Prompt.Count)];

        Console.WriteLine(Prompt.GetDisplayText());
    }
}
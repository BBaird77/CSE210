using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading;

class Reflection: Activity
{
    public static string[] Prompt =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public static string[] Question =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public override void RunActivity()
    {
        Random rnd = new();
        Console.WriteLine(Prompt[rnd.Next(Prompt.Length)]);
        Countdown(5);
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine(Question[rnd.Next(Question.Length)]);
            Countdown(5);
            elapsed += 5;
        }
    }
    public override string GetDescription() => "This activity helps you reflect on moments of strength and resilience.";
}
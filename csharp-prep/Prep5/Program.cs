using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        Console.Write("Please enter your name: ");
        string PromptUserName = Console.ReadLine();

        Console.Write("Please enter your favorite whole number: ");
        string inputnum = Console.ReadLine();
        double PromptUserNumber = double.Parse(inputnum); 

        double SquaredNumber = PromptUserNumber * PromptUserNumber;

        Console.WriteLine($"Hello {PromptUserName}, your favorite number squared is {SquaredNumber}!");
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
}
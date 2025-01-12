using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade (as a decimal)? ");
        string graderaw = Console.ReadLine();
        double grade = double.Parse(graderaw);
        
        string letter;
        
        if (grade >= 90)
        {
            letter = "A";
        }
        
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign;

        double end = (grade % 10);

        if (end >= 7)
        {
            sign = "+";
        }
        else if (end < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter == "F" && (sign == "+" || sign == "-"))
        {
            sign = "";
        }

        if (letter == "A" && (sign == "+"))
        {
            sign = "";
        }

        string n = (letter == "A" || letter == "F") ? "n" : "";

            Console.Write($"Your grade is a{n} {letter}{sign}. ");
    }
}
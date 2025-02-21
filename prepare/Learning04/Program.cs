using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment A = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(A.GetSummary());

        MathAssignment B = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(B.GetSummary());
        Console.WriteLine(B.GetHomeworkList());

        WritingAssignment C = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(C.GetSummary());
        Console.WriteLine(C.GetWritingInformation());
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int Enterednum = -1;

        while (Enterednum != 0)
        {
            Console.Write("Enter a list of numbers and type 0 to quit: ");
            
            string Choice = Console.ReadLine();
            Enterednum = int.Parse(Choice);
            
            if (Enterednum != 0)
            {
                numbers.Add(Enterednum);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the list is: {sum}");


        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average number is: {average}");
        

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
            
                max = number;
            }
        }
        Console.WriteLine($"The maximum number is: {max}");


         int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number < max && number > 0)
            {
            
                min = number;
            }
        }
        Console.WriteLine($"The minimum number is: {min}");
    }
}


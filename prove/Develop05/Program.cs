using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();
        goalManager.LoadGoalsFromFile();

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Total Score: {goalManager.GetScore()}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save & Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1": goalManager.AddGoal(); break;
                case "2": goalManager.RecordGoalTask(); break;
                case "3": goalManager.DisplayGoals(); break;
                case "4": goalManager.SaveGoalsToFile(); return;
            }
        }
    }
}
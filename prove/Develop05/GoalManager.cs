using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;
    private const string filePath = "goals.txt";

    public void AddGoal()
    {
        Console.WriteLine("Select Goal Type: 1) Simple  2) Eternal  3) Checklist");
        string choice = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1": goals.Add(new Simple(name, points)); break;
            case "2": goals.Add(new Eternal(name, points)); break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new Checklist(name, points, targetCount, bonus));
                break;
        }
    }

    public void RecordGoalTask()
    {
        DisplayGoals();
        Console.Write("Enter goal number to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
        {
            totalScore += goals[index].RecordEvent();
            Console.WriteLine("Event recorded!");
        }
        else
            Console.WriteLine("Invalid selection!");
        Console.ReadKey();
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].Name}");
        Console.ReadKey();
    }

    public void SaveGoalsToFile()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(totalScore);
            foreach (var goal in goals)
                writer.WriteLine(goal.Breakdown());
        }
    }

    public void LoadGoalsFromFile()
    {
        if (!File.Exists(filePath)) return;

        using (StreamReader reader = new StreamReader(filePath))
        {
            totalScore = int.Parse(reader.ReadLine());
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                switch (parts[0])
                {
                    case "Simple": goals.Add(new Simple(parts[1], int.Parse(parts[2])) {Completed = bool.Parse(parts[3]) }); break;
                    case "Eternal": goals.Add(new Eternal(parts[1], int.Parse(parts[2]))); break;
                    case "Checklist": goals.Add(new Checklist(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4])){Completed = bool.Parse(parts[5])});break;
                }
            }
        }
    }

    public int GetScore()
    {
        return totalScore;
    }
}
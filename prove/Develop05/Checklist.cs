using System;
using System.Collections.Generic;
using System.IO;

class Checklist: Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public Checklist(string name, int points, int targetCount, int bonusPoints)
        : base(name, points)
    {
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (!Completed)
        {
            currentCount++;
            if (currentCount >= targetCount)
            {
                Completed = true;
                return Points + bonusPoints;
            }
            return Points;
        }
        return 0;
    }

    public override string GetStatus() => Completed ? "[X]" : $"[{currentCount}/{targetCount}]";
    public override string Breakdown() => $"Checklist,{Name},{Points},{targetCount},{currentCount},{bonusPoints},{Completed}";
}
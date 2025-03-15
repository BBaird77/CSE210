using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    protected string Name;
    protected int Points;
    protected bool Completed;

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        Completed = false;
    }

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string Serialize();
}
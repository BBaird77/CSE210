using System;
using System.Collections.Generic;
using System.IO;

class Simple : Goal
{
    public Simple(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        if (!Completed)
        {
            Completed = true;
            return Points;
        }
        return 0;
    }

    public override string GetStatus() => Completed ? "[X]" : "[ ]";
    public override string Breakdown() => $"Simple,{Name},{Points},{Completed}";
}
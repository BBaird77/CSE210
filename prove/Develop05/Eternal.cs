using System;
using System.Collections.Generic;
using System.IO;

class Eternal : Goal
{
    public Eternal(string name, int points) : base(name, points) { }

    public override int RecordEvent() => Points;
    public override string GetStatus() => "[∞]";
    public override string Breakdown() => $"Eternal,{Name},{Points}";
}

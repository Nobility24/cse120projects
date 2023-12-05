using System;
using System.Collections.Generic;

// Base class for goals
public abstract class Goal
{
    private string name;
    protected int points;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public string Name => name;

    public abstract void RecordEvent();
    public abstract void DisplayProgress();
}
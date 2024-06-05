using System;

public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public bool Completed { get; set; }

    protected Goal(string name, int points)
    {
        Name = name;
        Points = points;
        Completed = false;
    }

    public abstract int MarkComplete();
    public abstract string GetStatus();
}

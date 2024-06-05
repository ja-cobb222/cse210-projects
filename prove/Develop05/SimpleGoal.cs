using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) 
    {
    }

    public override int MarkComplete()
    {
        if (!Completed)
        {
            Completed = true;
            return Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"Simple Goal: {Name}, Points: {Points}, Completed: {Completed}";
    }
}

public class EternalGoal : Goal
{
    public int CompletionCount { get; set; }
    
    public EternalGoal(string name, int points) : base(name, points)
    {
        CompletionCount = 0;
    }

    public override int MarkComplete()
    {
        CompletionCount++;
        return Points;
    }

    public override string GetStatus()
    {
        return $"Eternal Goal: {Name}, Points: {Points}, Completion: {CompletionCount}";
    }
}

public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    public override int MarkComplete()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            if (CurrentCount >= TargetCount)
            {
                Completed = true;
                return Points + BonusPoints;
            }
            return Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"Checklist Goal: {Name}, Points: {Points}, Current Count: {CurrentCount}/{TargetCount}, Completed: {Completed}";
    }
}

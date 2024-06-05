public class ProgressiveGoal : Goal
{
    public int TotalMilestones { get; set; }
    public int CurrentMilestone { get; set; }
    public int MilestonePoints { get; set; }
    public int BonusPoints { get; set; }

    public ProgressiveGoal(string name, int milestonePoints, int totalMilestones, int bonusPoints) 
        : base(name, milestonePoints)
    {
        MilestonePoints = milestonePoints;
        TotalMilestones = totalMilestones;
        CurrentMilestone = 0;
        BonusPoints = bonusPoints;
    }

    public override int MarkComplete()
    {
        if (CurrentMilestone < TotalMilestones)
        {
            CurrentMilestone++;
            if (CurrentMilestone == TotalMilestones)
            {
                Completed = true;
                return MilestonePoints + BonusPoints;
            }
            return MilestonePoints;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"Progressive Goal: {Name}, Milestones: {CurrentMilestone}/{TotalMilestones}, Points per milestone: {MilestonePoints}, Bonus: {BonusPoints}, Completed: {Completed}";
    }
}

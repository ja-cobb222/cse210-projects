using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class GoalConverter : JsonConverter<Goal>
{
    public override Goal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            JsonElement root = doc.RootElement;
            string type = root.GetProperty("Type").GetString();
            string name = root.GetProperty("Name").GetString();
            int points = root.GetProperty("Points").GetInt32();
            bool completed = root.GetProperty("Completed").GetBoolean();

            switch (type)
            {
                case nameof(EternalGoal):
                    int completionCount = root.GetProperty("CompletionCount").GetInt32();
                    EternalGoal eternalGoal = new EternalGoal(name, points)
                    {
                        CompletionCount = completionCount,
                        Completed = completed
                    };
                    return eternalGoal;

                case nameof(ChecklistGoal):
                    int targetCount = root.GetProperty("TargetCount").GetInt32();
                    int currentCount = root.GetProperty("CurrentCount").GetInt32();
                    int bonusPoints = root.GetProperty("BonusPoints").GetInt32();
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, points, targetCount, bonusPoints)
                    {
                        CurrentCount = currentCount,
                        Completed = completed
                    };
                    return checklistGoal;

                case nameof(SimpleGoal):
                    SimpleGoal simpleGoal = new SimpleGoal(name, points)
                    {
                        Completed = completed
                    };
                    return simpleGoal;

                case nameof(ProgressiveGoal):
                    int totalMilestones = root.GetProperty("TotalMilestones").GetInt32();
                    int currentMilestone = root.GetProperty("CurrentMilestone").GetInt32();
                    int milestonePoints = root.GetProperty("MilestonePoints").GetInt32();
                    int progBonusPoints = root.GetProperty("BonusPoints").GetInt32();
                    ProgressiveGoal progressiveGoal = new ProgressiveGoal(name, milestonePoints, totalMilestones, progBonusPoints)
                    {
                        CurrentMilestone = currentMilestone,
                        Completed = completed
                    };
                    return progressiveGoal;

                default:
                    throw new NotSupportedException($"Goal type '{type}' is not supported.");
            }
        }
    }

    public override void Write(Utf8JsonWriter writer, Goal value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("Type", value.GetType().Name);
        writer.WriteString("Name", value.Name);
        writer.WriteNumber("Points", value.Points);
        writer.WriteBoolean("Completed", value.Completed);

        switch (value)
        {
            case EternalGoal eternalGoal:
                writer.WriteNumber("CompletionCount", eternalGoal.CompletionCount);
                break;
            case ChecklistGoal checklistGoal:
                writer.WriteNumber("TargetCount", checklistGoal.TargetCount);
                writer.WriteNumber("CurrentCount", checklistGoal.CurrentCount);
                writer.WriteNumber("BonusPoints", checklistGoal.BonusPoints);
                break;
            case ProgressiveGoal progressiveGoal:
                writer.WriteNumber("TotalMilestones", progressiveGoal.TotalMilestones);
                writer.WriteNumber("CurrentMilestone", progressiveGoal.CurrentMilestone);
                writer.WriteNumber("MilestonePoints", progressiveGoal.MilestonePoints);
                writer.WriteNumber("BonusPoints", progressiveGoal.BonusPoints);
                break;
        }

        writer.WriteEndObject();
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class EternalQuest
{
    private List<Goal> goals;
    public int Score { get; private set; }

    public EternalQuest()
    {
        goals = new List<Goal>();
        Score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
        Console.WriteLine($"Added goal: {goal.Name}");
    }

    public int RecordEvent(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.Name == goalName)
            {
                int points = goal.MarkComplete();
                Score += points;
                Console.WriteLine($"Recorded event for goal: {goalName}, Points earned: {points}, Total score: {Score}");
                return points;
            }
        }
        Console.WriteLine($"Goal not found: {goalName}");
        return 0;
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {Score}");
    }

    public void ShowGoals()
    {
        if (goals == null || goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetStatus());
        }
    }

    public void Save(string filename = "goals.json")
    {
        var data = new
        {
            Score = this.Score,
            Goals = this.goals
        };

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new GoalConverter() }
        };

        string jsonString = JsonSerializer.Serialize(data, options);
        File.WriteAllText(filename, jsonString);
        Console.WriteLine("Goals saved to file.");
    }

    public void Load(string filename = "goals.json")
    {
        if (!File.Exists(filename))
        {
            goals = new List<Goal>();
            Console.WriteLine("File not found, initializing empty goals list.");
            return;
        }

        var options = new JsonSerializerOptions
        {
            Converters = { new GoalConverter() }
        };

        string jsonString = File.ReadAllText(filename);
        var data = JsonSerializer.Deserialize<EternalQuestData>(jsonString, options);

        Score = data.Score;
        goals = data.Goals;
        Console.WriteLine("Goals loaded from file.");
    }
}

public class EternalQuestData
{
    public int Score { get; set; }
    public List<Goal> Goals { get; set; }
}

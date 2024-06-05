using System;

class Program
{
    static void Main(string[] args)
    {
        EternalQuest quest = new EternalQuest();

        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddGoal(quest);
                    break;
                case "2":
                    RecordEvent(quest);
                    break;
                case "3":
                    quest.ShowGoals();
                    break;
                case "4":
                    quest.DisplayScore();
                    break;
                case "5":
                    quest.Save("goals.json");
                    break;
                case "6":
                    quest.Load("goals.json");
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void AddGoal(EternalQuest quest)
    {
        Console.WriteLine("\nAdd Goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Progressive Goal");
        Console.Write("Select goal type: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                quest.AddGoal(new SimpleGoal(name, points));
                break;
            case "2":
                quest.AddGoal(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                quest.AddGoal(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            case "4":
                Console.Write("Enter total milestones: ");
                int totalMilestones = int.Parse(Console.ReadLine());
                Console.Write("Enter points per milestone: ");
                int milestonePoints = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int progBonusPoints = int.Parse(Console.ReadLine());
                quest.AddGoal(new ProgressiveGoal(name, milestonePoints, totalMilestones, progBonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type, please try again.");
                break;
        }
    }

    static void RecordEvent(EternalQuest quest)
    {
        Console.Write("Enter the name of the goal to record: ");
        string goalName = Console.ReadLine();
        int points = quest.RecordEvent(goalName);
        if (points > 0)
        {
            Console.WriteLine($"Event recorded. You gained {points} points.");
        }
        else
        {
            Console.WriteLine("Goal not found or already completed.");
        }
    }
}

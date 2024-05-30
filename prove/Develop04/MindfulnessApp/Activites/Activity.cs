using System;
using System.Threading;

namespace MindfulnessApp.Activities
{
    public abstract class Activity
    {
        public string Name { get; }
        public string Description { get; }

        protected Activity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        protected abstract void ExecuteActivity(int duration, int pauseDuration);
    
        protected void CustomPause(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        protected void ShowMessage(string title, string message)
        {
            Console.WriteLine($"\n{title}");
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
        }

        public void Start(int duration)
        {
            Console.WriteLine($"\nStarting {Name} Activity");
            Console.WriteLine(Description);
            Console.WriteLine("Enter the duration of the pause in the seconds: ");
            if (int.TryParse(Console.ReadLine(), out int pauseDuration))
            {
                Console.WriteLine("Get ready to begin...");
                CustomPause(5);
                ExecuteActivity(duration, pauseDuration);
                Console.WriteLine($"\nYou have completed the {Name} activity for {duration} seconds.");
                CustomPause(5);
            }
            else
            {
                Console.WriteLine("Invalid pause duration. Please enter a number.");
            }
        }
    }
}
using System;
using MindfulnessApp.Activities;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var activities = new Dictionary<string, Activity>
            {
                { "1", new BreathingActivity() },
                { "2", new ReflectionActivity() },
                { "3", new ListingActivity() }
            };

            while (true)
            {
                Console.WriteLine("\nChoose an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine();

                if (choice == "4")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if (activities.ContainsKey(choice))
                {
                    Console.Write("Enter the duration of the activity in seconds: ");
                    if (int.TryParse(Console.ReadLine(), out int duration))
                    {
                        activities[choice].Start(duration);
                    }
                    else 
                    {
                        Console.WriteLine("Invalid duration. Please enter a number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}
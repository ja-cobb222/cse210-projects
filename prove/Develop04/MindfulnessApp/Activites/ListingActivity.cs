using System;
using System.Collections.Generic;

namespace MindfulnessApp.Activities
{
    public class ListingActivity : Activity
    {
        private readonly List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        protected override void ExecuteActivity(int duration, int pauseDuration)
        {
            var random = new Random();
            string prompt = _prompts[random.Next(_prompts.Count)];
            ShowMessage("List as many as you can:", prompt);
            CustomPause(3);

            int count = 0;
            DateTime startTime = DateTime.Now;
            while ((DateTime.Now - startTime).TotalSeconds < duration)
            {
                Console.Write("> ");
                Console.ReadLine();
                count++;
            }

            ShowMessage("Items listed", $"You listed {count} items.");
            CustomPause(3);
        }
    }
}
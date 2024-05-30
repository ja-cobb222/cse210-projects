using System;
using System.Collections.Generic;

namespace MindfulnessApp.Activities
{
    public class ReflectionActivity : Activity
    {
        private readonly List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private readonly List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        private static readonly Random Random = new Random();
        
        public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
        }

        protected override void ExecuteActivity(int duration, int pauseDuration)
        {
            string prompt = _prompts[Random.Next(_prompts.Count)];
            ShowMessage("Reflect on this:", prompt);

            int elapsed = 0;

            while (elapsed < duration)
            {
                string question = _questions[Random.Next(_questions.Count)];
                ShowMessage(question, "");
                CustomPause(pauseDuration);
                elapsed += pauseDuration;
            }
        }
    }
}
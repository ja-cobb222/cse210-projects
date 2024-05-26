using System;

public class PromptGenerator
{
    private static Random random = new Random();
    private static string[] prompts = {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? What caused that emotion? ",
        "If I had one thing I could do over today, what would it be? "
    };

    public static string GetRandomPrompt()
    {
        return prompts[random.Next(prompts.Length)];
    }

}
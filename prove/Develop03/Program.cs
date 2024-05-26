// To exceed expectations, I included three different scriptures that are selected randomly to be memorized. 

using System;
using System.Collections.Generic;

public class Program
{
    private static List<Scripture> scriptures;

    public static void Main(string[] args)
    {
        LoadScriptures();
        var scripture = scriptures[new Random().Next(scriptures.Count)];
        Console.Clear();
        Console.WriteLine(scripture);

        while (true)
        {
            Console.Write("\nPress Enter to hide words or type 'q' to exit.\n>");
            var input = Console.ReadLine();
            if (input.ToLower() == "q") break;

            scripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(scripture);
            if (scripture.Words.All(w => w.IsHidden))
            {
                Console.WriteLine("All words are hidden! Well done!!");
                break;
            }
        }
    }

    private static void LoadScriptures()
    {
        scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave is only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.")
        };
    }
}
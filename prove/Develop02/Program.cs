using System;

public class Program
{
    private static Journal journal = new Journal();

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    WriteNewEntry();
                    break;
                case 2:
                    DisplayJournal();
                    break;
                case 3:
                    // code for saving
                case 4:
                    // code for loading
                case 5:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again. ");
                    break;
            }
        }  
    }

    private static void WriteNewEntry()
    {
        string randomPrompt = PromptGenerator.GetRandomPrompt();

        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.Write("Enter your response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToString("yyyy-MM-dd");

        Entry entry = new Entry(randomPrompt, response, date);
        journal.AddEntry(entry);

        Console.WriteLine("Entry added successfully! ");
    }

    private static void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:\n");
        journal.DisplayEntries();
    }
}
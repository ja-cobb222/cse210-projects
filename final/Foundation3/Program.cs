using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Main St", "Anytown", "Anystate", "12345");
        Event lecture = new Lecture("Tech Talk", "A lecture on the latest in tech", "2024-06-10", "10:00 AM", address1, "Jane Doe", 100);
        
        Address address2 = new Address("456 Elm St", "Othertown", "Otherstate", "67890");
        Event reception = new Reception("Company Mixer", "A networking event for company employees", "2024-06-15", "6:00 PM", address2, "rsvp@company.com");
        
        Address address3 = new Address("789 Oak St", "Sometown", "Somestate", "101112");
        Event outdoorGathering = new OutdoorGathering("Summer Picnic", "A fun picnic in the park", "2024-06-20", "12:00 PM", address3, "Sunny and warm");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (Event e in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine("\nShort Description:");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("--------------------------------------------------\n");
        }
    }
}

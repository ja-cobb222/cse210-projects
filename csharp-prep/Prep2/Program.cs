using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        if (percent >= 90)
        {
            Console.WriteLine("Your grade is an A. ");
        }

        else if (percent >= 80 && percent < 90)
        {
            Console.WriteLine("Your grade is a B. ");
        }

        else if (percent >= 70 && percent < 80)
        {
            Console.WriteLine("Your grade is a C. ");
        }

        else if (percent >= 60 && percent < 70)
        {
            Console.WriteLine("Your grade is a D. ");
        }
        
        else if (percent >= 0 && percent < 60)
        {
            Console.WriteLine("Your grade is an F. ");
        }

    }
}
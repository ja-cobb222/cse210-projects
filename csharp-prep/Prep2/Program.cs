using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        if (percent >= 93 && percent < 100)
        {
            Console.WriteLine("Your grade is an A. ");
        }
        else if (percent >= 90 && percent < 93)
        {
            Console.WriteLine("Your grade is an A-. ");
        }



        else if (percent >= 87 && percent < 90)
        {
            Console.WriteLine("Your grade is a B+. ");
        }
        else if (percent >= 84 && percent < 87)
        {
            Console.WriteLine("Your grade is a B. ");
        }
        else if (percent >= 80 && percent < 83)
        {
            Console.WriteLine("Your grade is a B-. ");
        }



        else if (percent >= 77 && percent < 80)
        {
            Console.WriteLine("Your grade is a C+. ");
        }
        else if (percent >= 73 && percent < 77)
        {
            Console.WriteLine("Your grade is a C. ");
        }
        else if (percent >= 70 && percent < 73)
        {
            Console.WriteLine("Your grade is a C-. ");
        }



        else if (percent >= 67 && percent < 70)
        {
            Console.WriteLine("Your grade is a D+. ");
        }
        else if (percent >= 63 && percent < 67)
        {
            Console.WriteLine("Your grade is a D. ");
        }
        else if (percent >= 60 && percent < 63)
        {
            Console.WriteLine("Your grade is a D-. ");
        }



        else if (percent >= 0 && percent < 60)
        {
            Console.WriteLine("Your grade is an F. ");
        }

    }
}
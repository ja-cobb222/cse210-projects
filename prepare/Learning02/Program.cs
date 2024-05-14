using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Senior Software Engineer";
        job1._company = "Mighty Coconut";
        job1._startYear = 2030;
        job1._endYear = 2050;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2025;
        job2._endYear = 2030;


        Resume myResume = new Resume();
        myResume._name = "Isaac Jacobsen";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
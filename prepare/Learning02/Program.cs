using System;

class Program
{
    static void Main(string[] args)
    {
        Job job01 = new Job();
        job01._jobTitle = "Software Engineer";
        job01._company = "Microsoft";
        job01._startYear = 2019;
        job01._endYear = 2022;

        Job job02 = new Job();
        job02._jobTitle = "Manager";
        job02._company = "Apple";
        job02._startYear = 2022;
        job02._endYear = 2023;

        Resume resume = new Resume();
        resume._personName = "Allison Rose";

        resume._jobs.Add(job01);
        resume._jobs.Add(job02);

        resume.Display();

    }
}
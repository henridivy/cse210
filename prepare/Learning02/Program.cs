using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Graphic Designer";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job1.Display();
        job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Henrietta Gabriel";
        
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        Console.WriteLine();

        resume1.Display();

    }
}
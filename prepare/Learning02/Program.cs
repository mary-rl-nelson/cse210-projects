using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Amazon";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1997;
        job1._endYear = 2018;
        //job1.Display();

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Software Designer";
        job2._startYear = 2018;
        job2._endYear = 2024;
        //job2.Display();

        Job job3 = new Job();
        job3._company = "Microsoft";
        job3._jobTitle = "Software Designer";
        job3._startYear = 2018;
        job3._endYear = 2024;
        //job3.Display();

        Job job4 = new Job();
        job4._company = "Tootles";
        job4._jobTitle = "Software Designer";
        job4._startYear = 2018;
        job4._endYear = 2024;
        //job4.Display();

        Resume resume1 = new Resume();
        resume1._name = "Alice Jackson";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
        //Console.WriteLine(resume1._jobs[1]._jobTitle);

        Resume resume2 = new Resume();
        resume2._name = "Jack Butts";
        resume2._jobs.Add(job3);
        resume2._jobs.Add(job4);
        resume2.Display();

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "LCSS";
        job1._jobTitle = "Teacher";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._company = "FamilySearch";
        job2._jobTitle = "Web Developer";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Brienna Sambrano";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();

    }
}
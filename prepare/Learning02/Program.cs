using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 =new Job();
        job1._jobTitle = "Project manager";
        job1._company = "U.S. Air Force";
        job1._startYear = 2012;
        job1._endYear = 2017;

        Job job2 = new Job();
        job2._jobTitle = "Analyst";
        job2._company = "CIA";
        job2._startYear= 2018;
        job2._endYear= 2023;

        Resume myResume = new Resume();
        myResume._name = "Mosiah Valdez";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }

}
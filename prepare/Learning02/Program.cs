using System;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Mercedes-Benz SA";
        job2._startYear = 2023;
        job2._endYear = 2029;
        

        Resume resume1 = new Resume();
        resume1._name = "Ntombesizwe Hontyo";
        resume1._jobList.Add(job1);
        resume1._jobList.Add(job2);
        resume1.DisplayResume();
        
        
    }

}
using System;

class Program
{

    static void Main(string[] args)
    {
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2021);
        
        Job job2 = new Job();
        job2._company = "Samsung";
        job2._jobTitle = "Chip Engineer";
        job2._startYear = 1999;
        job2._endYear = 2010;

        Resume resume1 = new Resume("Bob Aaron", new List<Job>{job1, job2});
        resume1.Display();
    }
}
using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate through each job instance in the _jobs list
        foreach (Job job in _jobs)
        {
           // Call the display method on each job 
           job.DisplayJobDetails();
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // A list of activity
        List<Activity> activity = new List<Activity>();

        // Instantiate instances of Running, Cycling and Swimming class
        Running runningActivity = new Running(20, 60, "20 Jul 2023");
        Cycling cyclingActivity = new Cycling(10, 30, "15 Aug 2023");
        Swimming swimmingActivity = new Swimming(43, 45, "30 Aug 2023");

        // Add the instances to the Activity list
        activity.Add(runningActivity);
        activity.Add(cyclingActivity);
        activity.Add(swimmingActivity);

        // Loop through the activity list and output the results
        foreach (Activity sport in activity)
        {
            Console.WriteLine(sport.GetSummary());
            Console.WriteLine();
        }
    }
}
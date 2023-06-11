public class Activity
{
    protected string _name;
    protected string _description;
    private int _activityDuration;

    public int Duration
    {
        get { return _activityDuration; }
        set { _activityDuration = value; }
    }

    public void CountDown(int duration = 5)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }

    public void ClearConsole()
    {
        Console.Clear();
    }

    public void DisplayStartMessage()
    {
        ClearConsole();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        Spin();
        Console.WriteLine($"\nYou have completed another {_activityDuration} seconds of the {_name} Activity.");
        Spin();
    }

    public void Spin(int duration = 5)
    {
        int index = 0;
        string animeString = "|/-\\|/\\";

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            char animeChar = animeString[index];
            Console.Write(animeChar);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            index++;

            if (index >= animeString.Length)
            {
                index = 0;
            }
        }
    }
}
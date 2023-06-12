public class Activity
{
    protected string _name;
    protected string _description;
    private int _activityDuration;
    private int _spinDuration;
    private int _countDownDuration;

    public Activity()
    {
        _spinDuration = 6;
        _countDownDuration = 5;
    }


    public int Duration
    {
        get { return _activityDuration; }
        set { _activityDuration = value; }
    }

    public void CountDown(int seconds = 0)
    {
        if (seconds != 0)
        {
            _countDownDuration = seconds;
        }

        for (int i = _countDownDuration; i > 0; i--)
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

    public void Spin(int seconds = 0)
    {
        int index = 0;
        string animeString = "|/-\\|/\\";

        if (seconds != 0)
        {
            _spinDuration = seconds;
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_spinDuration);

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
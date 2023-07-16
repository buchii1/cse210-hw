public abstract class Goal
{
    protected int _basePoint;
    protected int _point;
    protected int _totPoint;
    protected int _duration;
    protected string _description;
    protected string _name;
    protected bool _isComplete;

    public Goal()
    {
        _duration = 0;
        _point = 0;
        _totPoint = 0;
        _basePoint = 0;
    }

    public int ExtraPoints
    {
        get { return _totPoint; }
    }

    public int TotalPoint
    {
        get { return _basePoint; }
        set { _basePoint = value; }
    }

    public string Name
    {
        get { return _name; }
    }

    public int Point
    {
        get { return _point; }
    }

    public virtual int RecordEvent()
    {
        int totalPoints = _basePoint += _point;
        return totalPoints;
    }

    public virtual void LoadGoalDetails(string[] sharedDetails)
    {
        _name = sharedDetails[0];
        _description = sharedDetails[1];
        _point = int.Parse(sharedDetails[2]);
    }

    public virtual string DisplayGoal()
    {
        return CheckCompletionStatus() ? "X" : " ";
    }

    public virtual void DisplayProgressMessage()
    {

    }

    public abstract bool CheckCompletionStatus();

    public abstract string SaveGoalDetails();


    public void Spin()
    {
        int index = 0;
        string animeString = "|/\\";

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);

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

    public virtual void DisplayStartMessage()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _point = int.Parse(Console.ReadLine());
    }
}

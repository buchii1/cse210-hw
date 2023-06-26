public abstract class Goal
{
    protected int _basePoint;
    protected int _point;

    protected int _duration;
    protected string _description;
    protected string _name;
    protected bool _isComplete;

    public Goal()
    {
        _duration = 0;
        _point = 0;
        _basePoint = 0;
    }

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public int TotalPoint
    {
        get { return _basePoint; }
        set { _basePoint = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Point
    {
        get { return _point; }
        set { _point = value; }
    }

    public bool IsComplete
    {
        get { return _isComplete; }
        set { _isComplete = value; }
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

    public abstract bool CheckCompletionStatus();

    public abstract string SaveGoalDetails();

    public virtual string DisplayGoal()
    {
        return CheckCompletionStatus() ? "X" : " ";
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

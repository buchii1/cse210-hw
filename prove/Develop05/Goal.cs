public abstract class Goal
{
    private int _basePoint;
    private int _point;

    private int _duration;
    private string _description;
    private string _name;
    private bool _isComplete;

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

    public abstract bool CheckCompletionStatus();

    public abstract string GetDetails();

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

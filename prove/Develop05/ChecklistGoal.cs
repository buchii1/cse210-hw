public class ChecklistGoal : Goal
{
    private int _numOfTimesAccomplished;
    private int _bonusPoints;

    public ChecklistGoal()
    {
        _numOfTimesAccomplished = 0;
        _bonusPoints = 0;
    }
    public int Bonus
    {
        get { return _bonusPoints; }
        set { _bonusPoints = value; }
    }

    public int NumOfAccomplishments
    {
        get { return _numOfTimesAccomplished; }
        set { _numOfTimesAccomplished = value; }
    }

    public override bool CheckCompletionStatus()
    {
        IsComplete = false;

        if (_numOfTimesAccomplished >= Duration)
        {
            IsComplete = true;
        }

        return IsComplete;
        
    }

    public override int RecordEvent()
    {
        int totalPoints;
        _numOfTimesAccomplished++;

        if (CheckCompletionStatus())
        {
            totalPoints = TotalPoint += (_bonusPoints + Point);
        }
        else
        {
            totalPoints = TotalPoint += Point;
        }

        return totalPoints;
    }

    public override string DisplayGoal()
    {
        string status = base.DisplayGoal();
        return $"[{status}] {Name} ({Description}) --- Currently completed: {_numOfTimesAccomplished}/{Duration}\n";
    }

    public override string GetDetails()
    {
        return $"{Name} || {Description} || {Point} || {_bonusPoints} || {Duration} || {_numOfTimesAccomplished}";
    }

    public override void DisplayStartMessage()
    {
        base.DisplayStartMessage();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        Duration = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
}

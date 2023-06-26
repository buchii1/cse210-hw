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
        _isComplete = false;

        if (_numOfTimesAccomplished >= _duration)
        {
            _isComplete = true;
        }

        return _isComplete;
        
    }

    public override int RecordEvent()
    {
        int totalPoints = 0;
        _numOfTimesAccomplished++;

        if (CheckCompletionStatus())
        {
            totalPoints = TotalPoint += (_bonusPoints + _point);
        }
        else
        {
            totalPoints = TotalPoint += _point;
        }

        return totalPoints;
    }

    public override string DisplayGoal()
    {
        string status = base.DisplayGoal();
        return $"[{status}] {_name} ({_description}) --- Currently completed: {_numOfTimesAccomplished}/{_duration}\n";
    }

    public override void LoadGoalDetails(string[] sharedDetails)
    {
    base.LoadGoalDetails(sharedDetails);
    _bonusPoints = int.Parse(sharedDetails[3]);
    _duration = int.Parse(sharedDetails[4]);
    _numOfTimesAccomplished = int.Parse(sharedDetails[5]);
    }

    public override string SaveGoalDetails()
    {
        return $"{_name} || {_description} || {_point} || {_bonusPoints} || {_duration} || {_numOfTimesAccomplished}";
    }

    public override void DisplayStartMessage()
    {
        base.DisplayStartMessage();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
}

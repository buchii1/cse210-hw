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
        int totalPoints;
        _numOfTimesAccomplished++;

        if (CheckCompletionStatus())
        {
            totalPoints = _basePoint += (_bonusPoints + _point);
            _point += _bonusPoints;
        }
        else
        {
            totalPoints = _basePoint += _point;
        }

        return totalPoints;
    }

    public override string DisplayGoal()
    {
        string status = CheckCompletionStatus() ? "X" : " ";
        return $"[{status}] {_name} ({_description}) --- Currently completed: {_numOfTimesAccomplished}/{_duration}\n";
    }

    public override string GetDetails()
    {
        return $"{_name} || {Description} || {GetPoint} || {_bonusPoints} || {_duration} || {_numOfTimesAccomplished}";
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

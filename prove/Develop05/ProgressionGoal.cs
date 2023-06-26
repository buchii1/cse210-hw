public class ProgressionGoal : Goal
{
    private int _totalLevel;

    private int _currentLevel;
    private int _bonusPoints;
    private int _progress;
    private int _completionBonus;

    public int Bonus
    {
        get { return _bonusPoints; }
        set { _bonusPoints = value; }
    }

    public int TotalLevel
    {
        get { return _totalLevel; }
        set { _totalLevel = value; }
    }

    public int CurrentLevel
    {
        get { return _currentLevel; }
        set { _currentLevel = value; }
    }

    public int Progress
    {
        get { return _progress; }
        set { _progress = value; }
    }

    public int CompletionBonus
    {
        get { return _completionBonus; }
        set { _completionBonus = value; }
    }
    
    public override int RecordEvent()
    {
        int totalPoints;
        _progress++;

        if (_progress == Duration)
        {
            _currentLevel ++;
            totalPoints = TotalPoint += (_bonusPoints + Point);
        }

        else if  (CheckCompletionStatus())
        {
            totalPoints = TotalPoint += (_bonusPoints + Point + _completionBonus);
        }
        else
        {
            totalPoints = TotalPoint += Point;
        }

        return totalPoints;
    }

    public override bool CheckCompletionStatus()
    {
        IsComplete = false;

        if (_currentLevel == _totalLevel)
        {
            IsComplete = true;
        }

        return IsComplete;
    }

    public override string DisplayGoal()
    {
        string status = base.DisplayGoal();
        return $"[{status}] {Name} ({Description}) --- Currently completed => (Level: {_progress}/{Duration} - Stage: {_currentLevel}/{_totalLevel})\n";
        
    }

    public override void LoadGoalDetails(string[] sharedDetails)
    {
    base.LoadGoalDetails(sharedDetails);
    _bonusPoints = sharedDetails[3];
    _completionBonus = sharedDetails[4];
    _progress = sharedDetails[5];
    _duration = sharedDetails[6];
    _currentLevel = sharedDetails[7];
    _totalLevel = sharedDetails[8];
    }
    

    public override string GetDetails()
    {
        return $"{_name} || {_description} || {Point} || {_bonusPoints} || {_completionBonus} || {_progress} || {Duration} || {_currentLevel} || {_totalLevel}";
    }

    public override void DisplayStartMessage()
    {
        base.DisplayStartMessage();
        Console.Write("How many levels does this goal have? ");
        _totalLevel = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished to level up? ");
        Duration = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for leveling up? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for completing all levels? ");
        _completionBonus = int.Parse(Console.ReadLine());
    }
}

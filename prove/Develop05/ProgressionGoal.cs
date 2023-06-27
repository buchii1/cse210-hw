public class ProgressionGoal : Goal
{
    private int _totalLevel;

    private int _currentLevel;
    private int _bonusPoints;
    private int _progress;
    private int _completionBonus;

    public override int RecordEvent()
    {
        int totalPoints = 0;
        _progress++;

        if (_progress == _duration)
        {
            _currentLevel++;
            totalPoints = TotalPoint += (_bonusPoints + _point);
        }

        else if (CheckCompletionStatus())
        {
            totalPoints = TotalPoint += (_bonusPoints + _point + _completionBonus);
        }
        else
        {
            totalPoints = TotalPoint += _point;
        }

        return totalPoints;
    }

    public override bool CheckCompletionStatus()
    {
        _isComplete = false;

        if (_currentLevel == _totalLevel)
        {
            _isComplete = true;
        }

        return _isComplete;
    }

    public override void DisplayProgressMessage()
    {
        if (_progress == _duration)
        {
            Console.WriteLine($"Level {_currentLevel} completed.");
            _progress = 0;
            _totPoint = _bonusPoints;
            Spin();
        }

        if (CheckCompletionStatus())
        {
            _totPoint = 0; // Reset value to zero
            Console.WriteLine($"You have completed all {_totalLevel} levels of the {_name} goal. You rock!");
            _totPoint = _bonusPoints + _completionBonus;
            Spin();
        }
    }

    public override string DisplayGoal()
    {
        string status = base.DisplayGoal();
        return $"[{status}] {_name} ({_description}) --- Currently completed => (Level: {_progress}/{_duration} - Stage: {_currentLevel}/{_totalLevel})\n";
    }

    public override void LoadGoalDetails(string[] sharedDetails)
    {
        base.LoadGoalDetails(sharedDetails);
        _bonusPoints = int.Parse(sharedDetails[3]);
        _completionBonus = int.Parse(sharedDetails[4]);
        _progress = int.Parse(sharedDetails[5]);
        _duration = int.Parse(sharedDetails[6]);
        _currentLevel = int.Parse(sharedDetails[7]);
        _totalLevel = int.Parse(sharedDetails[8]);
    }

    public override string SaveGoalDetails()
    {
        return $"{_name} || {_description} || {_point} || {_bonusPoints} || {_completionBonus} || {_progress} || {_duration} || {_currentLevel} || {_totalLevel}";
    }

    public override void DisplayStartMessage()
    {
        base.DisplayStartMessage();
        Console.Write("How many levels does this goal have? ");
        _totalLevel = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished to level up? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for leveling up? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for completing all levels? ");
        _completionBonus = int.Parse(Console.ReadLine());
    }
}

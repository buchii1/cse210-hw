public class SimpleGoal : Goal
{
    public override int RecordEvent()
    {
        int totalPoints = TotalPoint += _point;
        _duration++;
        return totalPoints;
    }

    public override bool CheckCompletionStatus()
    {
        _isComplete = false;

        if (_duration > 0)
        {
            _isComplete = true;
        }

        return _isComplete;
    }

    public override string DisplayGoal()
    {
        string status = base.DisplayGoal();
        return $"[{status}] {_name} ({_description})\n";
    }

    public override void LoadGoalDetails(string[] sharedDetails)
    {
        base.LoadGoalDetails(sharedDetails);
        _duration = int.Parse(sharedDetails[3]);
    }

    public override string SaveGoalDetails()
    {
        return $"{_name} || {_description} || {_point} || {_duration}";
    }
}

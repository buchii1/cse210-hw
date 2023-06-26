public class EternalGoal : Goal
{
    public override bool CheckCompletionStatus()
    {
        return _isComplete = false;
    }

    public override string DisplayGoal()
    {
        string status = base.DisplayGoal();
        return $"[{status}] {_name} ({_description})\n";
    }

    public override string SaveGoalDetails()
    {
        return $"{_name} || {_description} || {_point}";
    }
}

public class EternalGoal : Goal
{
    public override bool CheckCompletionStatus()
    {
        return _isComplete = false;
    }

    public override string GetDetails()
    {
        return $"{_name} || {Description} || {GetPoint}";
    }
}
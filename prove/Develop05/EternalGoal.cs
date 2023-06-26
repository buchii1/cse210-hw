public class EternalGoal : Goal
{
    public override bool CheckCompletionStatus()
    {
        return IsComplete = false;
    }

    public override string DisplayGoal()
    {
        string status = base.DisplayGoal();
        return $"[{status}] {_name} ({_description})\n";
    }

    public override string GetDetails()
    {
        return $"{Name} || {Description} || {Point}";
    }
}

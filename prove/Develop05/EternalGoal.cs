public class EternalGoal : Goal
{
    public override bool CheckCompletionStatus()
    {
        return IsComplete = false;
    }

    public override string DisplayGoal()
    {
        string status = base.DisplayGoal();
        return $"[{status}] {Name} ({Description})\n";
    }

    public override string GetDetails()
    {
        return $"{Name} || {Description} || {Point}";
    }
}
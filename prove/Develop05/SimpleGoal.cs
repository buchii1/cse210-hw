public class SimpleGoal : Goal
{
    public override int RecordEvent()
    {
        int totalPoints = TotalPoint += Point;
        Duration++;
        return totalPoints;
    }

    public override bool CheckCompletionStatus()
    {
        IsComplete = false;

        if (Duration > 0)
        {
            IsComplete = true;
        }

        return IsComplete;
    }

    public override string DisplayGoal()
    {
        string status = base.DisplayGoal();
        return $"[{status}] {Name} ({Description})\n";
    }

    public override string GetDetails()
    {
        return $"{Name} || {Description} || {Point} || {Duration}";
    }
}
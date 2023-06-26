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
        return $"[{status}] {_name} ({_description})\n";
    }

    public override void LoadGoalDetails(string[] sharedDetails)
    {
   		base.LoadGoalDetails(sharedDetails);
   		_duration = int.Parse(sharedDetails[3]);
    }

    public override string GetDetails()
    {
        return $"{Name} || {Description} || {Point} || {Duration}";
    }
}

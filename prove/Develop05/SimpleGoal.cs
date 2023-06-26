public class SimpleGoal : Goal
{
    public override int RecordEvent()
    {
        int totalPoints = _basePoint += _point;
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

    public override string GetDetails()
    {
        return $"{_name} || {Description} || {GetPoint} || {_duration}";
    }
}
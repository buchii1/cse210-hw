public abstract class Activity
{
    protected int _length;
    protected string _date;

    public Activity(int length, string date)
    {
        _length = length;
        _date = date;
    }

    public abstract double CalcDistance();

    public abstract double CalcSpeed();

    public abstract double CalcPace();

    public string GetSummary()
    {
        string distance = $"Distance: {CalcDistance().ToString("0.0")} km";
        string speed = $"Speed: {CalcSpeed().ToString("0.0")} kph";
        string pace = $"Pace: {CalcPace().ToString("0.0")} min per km";

        return $"{_date} {GetType().Name} ({_length} min) - {distance}, {speed}, {pace}";
    }
}
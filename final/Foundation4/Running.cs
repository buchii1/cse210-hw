public class Running : Activity
{
    private double _distance;

    public Running(double distance, int length, string date) : base(length, date)
    {
        _distance = distance;
    }

    public override double CalcSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double CalcDistance()
    {
        return _distance;

    }

    public override double CalcPace()
    {
        return _length / _distance;
    }
}
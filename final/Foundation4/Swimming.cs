public class Swimming : Activity
{
    private int _laps;

    public Swimming(int laps, int length, string date) : base(length, date)
    {
        _laps = laps;
    }

    public override double CalcDistance()
    {
        return _laps * 50.0 / 1000.0;
    }

    public override double CalcSpeed()
    {
        return (CalcDistance() / _length) * 60;
    }

    public override double CalcPace()
    {
        return 60 / CalcSpeed();
    }
}
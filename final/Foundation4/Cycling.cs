public class Cycling : Activity
{
    private double _speed;

    public Cycling(double speed, int length, string date) : base(length, date)
    {
        _speed = speed;
    }

    public override double CalcDistance()
    {
        double time = (_length / 60.0); // Convert minutes to hours
        double distance = _speed * time;

        return distance;
    }

    public override double CalcSpeed()
    {
        return _speed;
    }

    public override double CalcPace()
    {
        return 60 / _speed;
    }
}
using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        this._speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_minutes / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Cycling ({_minutes} min) - Distance: {GetDistance()} miles, Speed: {_speed} mph, Pace: {GetPace()} min/miles";
    }
}

using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        this._laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_minutes / 60.0);
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Swimming ({_minutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}

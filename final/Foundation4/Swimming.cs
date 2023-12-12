public class Swimming : Activity
{
    private double _laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        var distance = _laps * (double)50 / (double)1000;
        return distance;
    }
    public override double GetSpeed()
    {
        return GetDistance() / (double)_minutes * 60;
    }
    public override double GetPace()
    {
        var pace = 60 / GetSpeed();
        return pace;

    }
    public override string GetSummary(string activityType = "Swimming")
    {
        return base.GetSummary(activityType);
    }

}
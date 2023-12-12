public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        var distance = _speed * (double)_minutes / (double)60;
        return distance;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        var pace = 60 / (double)_speed;
        return pace;

    }
    public override string GetSummary(string activityType = "Cycling")
    {
        return base.GetSummary(activityType);
    }

}
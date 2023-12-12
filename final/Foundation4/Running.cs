public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double speed = (double)_distance / (double)_minutes * (double)60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = (double)_minutes / (double)_distance;
        return pace;

    }
    public override string GetSummary(string activityType = "Running")
    {
        return base.GetSummary(activityType);
    }
}
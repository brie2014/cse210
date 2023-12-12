class Program
{
    static void Main()
    {
        List<Activity> _activities = new();

        Running running = new(DateTime.Parse("12/11/2023"), 30, 3);
        _activities.Add(running);

        Cycling cycling = new(DateTime.Parse("12/12/2023"), 45, 10);
        _activities.Add(cycling);

        Swimming swimming = new(DateTime.Parse("12/13/2023"), 30, 20);
        _activities.Add(swimming);

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());

        }

    }
}
public class OutdoorGathering : Event
{
    string _weather;

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        return $@"{base.GetStandardDetails()}
Weather: {_weather}. Please dress accordingly!";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor Gathering | {base.GetShortDescription()}";
    }
}
public class Lecture : Event
{
    string _speakerName;
    int _capacity;

    public Lecture(string title, string description, DateTime date, string time, Address address, string speakerName, int capacity) : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
    public override string GetFullDetails()
    {
        return $@"{base.GetStandardDetails()}
Who: {_speakerName}
Only {_capacity} seats available!";
    }

    public override string GetShortDescription()
    {
        return $"Lecture | {base.GetShortDescription()}";
    }
}
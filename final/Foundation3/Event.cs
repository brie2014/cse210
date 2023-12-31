public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $@"~{_title}~
What: {_description}
When: {_date:MM/dd/yyyy} at {_time}
Where: {_address.GetDetailsString()}";
    }

    public abstract string GetFullDetails();

    public virtual string GetShortDescription()
    {
        return $"{_title} | {_date:MM/dd/yyyy}";
    }
}
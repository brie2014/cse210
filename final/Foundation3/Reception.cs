public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, DateTime date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override string GetFullDetails()
    {
        return $@"{base.GetStandardDetails()}
Please RSVP to {_email}";
    }

    public override string GetShortDescription()
    {
        return $"Reception | {base.GetShortDescription()}";
    }
}
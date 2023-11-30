public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual int GetPoints()
    {
        return _points;
    }
    public virtual string GetName()
    {
        return _name;
    }

    public virtual string GetDetailsString()
    {
        return $"{_name} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_name},{_description},{_points}";
    }

}
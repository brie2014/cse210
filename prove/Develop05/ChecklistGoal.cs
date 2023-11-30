public class ChecklistGoal : Goal
{

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }


    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine();
            Console.WriteLine($"You just got a bonus for completing your goal {_target} times!");
            return GetPoints() + _bonus;
        }
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{base.GetStringRepresentation()},{_amountCompleted},{_target},{_bonus}";
    }
}
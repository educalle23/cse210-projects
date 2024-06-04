public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public int Bonus
    {
        get { return _bonus; }
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        return _points + (IsComplete() ? _bonus : 0);
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - {_points} points ({_amountCompleted}/{_target} completed, {_bonus} bonus)";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal, {_shortName}, {_description}, {_points}, {_amountCompleted}, {_target}, {_bonus}";
    }
}

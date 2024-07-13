class SimpleGoal : Goal
{
    public bool _isComplete;

    public SimpleGoal(string description, string details, int points)
    {
        _name = description;
        _details = details;
        _points = points;
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congrats you have eanred {_points} ");
            return _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        if (_isComplete)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }

    public override string Serialize()
    {
        return $"Simple#{_name}#{_details}#{_points}#{_isComplete}";
    }

    public static SimpleGoal Deserialize(string[] parts)
    {
        var goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
        goal._isComplete = bool.Parse(parts[4]);
        return goal;
    }
}

class EternalGoal : Goal
{
    public EternalGoal(string description, string details, int points)
    {
        _name = description;
        _details = details;
        _points = points;
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congrats you have eanred {_points} ");
        return _points;
    }

    public override string GetStatus()
    {
        return "[ ]";
    }

    public override string Serialize()
    {
        return $"Eternal#{_name}#{_details}#{_points}";
    }

    public static EternalGoal Deserialize(string[] parts)
    {
        return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
    }
}
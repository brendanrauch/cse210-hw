class ChecklistGoal : Goal
{
    public int _targetCount;
    public int _currentCount;
    public int _bonusPoints;

    public ChecklistGoal(string description, string details, int points, int targetCount, int bonusPoints)
    {
        _name = description;
        _details = details;
        _points = points;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {   
                Console.WriteLine($"Congrats you have eanred {_points + _bonusPoints} ");
                return _points + _bonusPoints;
            }
            Console.WriteLine($"Congrats you have eanred {_points} ");
            return _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        if (_currentCount == _targetCount)
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
        return $"Checklist#{_name}#{_details}#{_points}#{_targetCount}#{_currentCount}#{_bonusPoints}";
    }

    public static ChecklistGoal Deserialize(string[] parts)
    {
        var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[6]));
        goal._currentCount = int.Parse(parts[5]);
        return goal;
    }
}
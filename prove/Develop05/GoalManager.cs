class GoalManager
{
    private List<Goal> goals;
    private int totalScore;

    public GoalManager()
    {
        goals = new List<Goal>();
        totalScore = 0;
    }

    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select goal type: ");
        var goalType = Console.ReadLine();

        Console.Write("Enter goal Name: ");
        var description = Console.ReadLine();
        Console.Write("Enter goal details: ");
        var details = Console.ReadLine();
        Console.Write("Enter points: ");
        var points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                goals.Add(new SimpleGoal(description, details, points));
                break;
            case "2":
                goals.Add(new EternalGoal(description, details, points));
                break;
            case "3":
                Console.Write("Enter the amount of times this goal needs to be completed: ");
                var targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                var bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(description, details, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type. Please try again.");
                break;
        }
    }

    public void RecordEvent()
    {
        ShowGoals();
        Console.Write("Select goal number to record event: ");
        var goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < goals.Count)
        {
            totalScore += goals[goalNumber].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid goal number. Please try again.");
        }
    }

    public void ShowGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            var status = goals[i].GetStatus();
            var extraInfo = goals[i] is ChecklistGoal checklistGoal ? $" -- Currently completed: {checklistGoal._currentCount}/{checklistGoal._targetCount}" : string.Empty;
            Console.WriteLine($"{i + 1}. {status} {goals[i]._name} ({goals[i]._details}){extraInfo}");
        }
    }

    public void SaveData()
    {
        //I uesed the example and chatgpt to help write the save data and load data code. I picked the delimter of # to split text. it will write the goal in a text file then when ready it will read it and bring it back creating new goals
        Console.Write("Enter the filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(totalScore);
            foreach (var goal in goals)
            {
                outputFile.WriteLine(goal.Serialize());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadData()
    {
        Console.Write("Enter the filename to load goals: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            if (lines.Length > 0)
            {
                totalScore = int.Parse(lines[0]);
                goals.Clear();
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('#');
                    switch (parts[0])
                    {
                        case "Simple":
                            goals.Add(SimpleGoal.Deserialize(parts));
                            break;
                        case "Eternal":
                            goals.Add(EternalGoal.Deserialize(parts));
                            break;
                        case "Checklist":
                            goals.Add(ChecklistGoal.Deserialize(parts));
                            break;
                    }
                }
                Console.WriteLine("Goals loaded successfully.");
            }
        }
        else
        {
            Console.WriteLine("File not found. Please try again.");
        }
    }

    public int GetTotalScore()
    {
        return totalScore;
    }
}
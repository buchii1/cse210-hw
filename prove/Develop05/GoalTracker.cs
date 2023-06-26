public class GoalTracker
{
    private List<Goal> _goals = new List<Goal>();
    private List<string> _goalTypes;

    public GoalTracker()
    {
        _goalTypes = new List<string>
        {
            "Simple Goal",
            "Eternal Goal",
            "Checklist Goal",
            "Progression Goal"
        };
    }

    public void DisplayGoalTypes()
    {
        Console.WriteLine("The types of Goals are:");

        for (int i = 0; i < _goalTypes.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goalTypes[i]}");
        }

        Console.Write("Which type of goal would you like to create? ");
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.Write($"{i + 1}. ");
            Console.Write(goal.DisplayGoal());
        }
    }

    public int GetTotalScore()
    {
        int totalPoints = 0;

        foreach (Goal goal in _goals)
        {
            totalPoints += goal.TotalPoint;
        }

        return totalPoints;
    }

    public void RecordGoal()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. {goal.Name}");
        }

        Console.Write("What goal did you accomplish? ");
        int input = int.Parse(Console.ReadLine());
        Spin();

        Goal selectedGoal = _goals[input - 1];
        int pointsEarned = selectedGoal.RecordEvent();

        int bonusPoint = 0;

        if (selectedGoal is ProgressionGoal progressGoal)
        {
            if (progressGoal.Progress == progressGoal.Duration)
            {
                Console.WriteLine($"Level {progressGoal.CurrentLevel} completed.");
                progressGoal.Progress = 0;
                bonusPoint = progressGoal.Bonus;
                Spin();
            }
            if (progressGoal.CheckCompletionStatus())
            {
                Console.WriteLine($"You have completed all {progressGoal.TotalLevel} levels of the {progressGoal.Name} goal. You rock!");
                bonusPoint = progressGoal.Bonus + progressGoal.CompletionBonus;
                Spin();
            }
        }
        else if (selectedGoal is ChecklistGoal checklistGoal)
        {
            if (checklistGoal.CheckCompletionStatus())
            {
                Console.WriteLine($"You have completed the {checklistGoal.Name} goal. You rock!");
                bonusPoint = checklistGoal.Bonus;
                Spin();
            }
        }

        Console.WriteLine($"Congratulations! You have earned {selectedGoal.Point + bonusPoint} points!");
        Spin();
        Console.WriteLine($"You now have {GetTotalScore()} points.");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(GetTotalScore());

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetType().Name}: {goal.SaveGoalDetails()}");
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear(); // Clear existing goals before loading

        string[] entries = File.ReadAllLines(filename);

        string firstEntry = entries[0];
        int totalScore;

        if (!int.TryParse(firstEntry, out totalScore))
        {
            Console.WriteLine($"Invalid total score value: {firstEntry}");
            return;
        }

        Goal goal = null;

        for (int i = 0; i < entries.Length; i++)
        {
            string entry = entries[i];
            string[] parts = entry.Split(": ");

            if (parts.Length != 2)
            {
                // Console.WriteLine($"Invalid goal entry format: {entry}");
                continue;
            }

            string goalType = parts[0];
            string goalDetails = parts[1];

            switch (goalType)
            {
                case "ChecklistGoal":
                    goal = new ChecklistGoal();
                    break;
                case "EternalGoal":
                    goal = new EternalGoal();
                    break;
                case "SimpleGoal":
                    goal = new SimpleGoal();
                    break;
                case "ProgressionGoal":
                    goal = new ProgressionGoal();
                    break;
                default:
                    Console.WriteLine($"Invalid goal type found: {goalType}");
                    continue;
            }

            string[] sharedDetails = goalDetails.Split(" || ");

            goal.LoadGoalDetails(sharedDetails);

            _goals.Add(goal);
        }

        if (goal != null)
        {
            goal.TotalPoint = totalScore; // Assign the total score
        }
    }

    public void Spin()
    {
        int index = 0;
        string animeString = "|/-\\|/\\";

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(6);

        while (DateTime.Now < endTime)
        {
            char animeChar = animeString[index];
            Console.Write(animeChar);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            index++;

            if (index >= animeString.Length)
            {
                index = 0;
            }
        }
    }
}
public class GoalTracker
{
    private List<Goal> _goals = new List<Goal>();
    private List<string> _goalTypes;
    Menu menu = new Menu();

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
        if (_goals.Count != 0)
        {
            Console.WriteLine("The goals are:");

            for (int i = 0; i < _goals.Count; i++)
            {
                Goal goal = _goals[i];
                Console.Write($"{i + 1}. ");
                Console.Write(goal.DisplayGoal());
            }
        }
        else
        {
            Console.WriteLine("No goal(s) to display. Please add a goal.\n");
            menu.DisplayMenu();
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
        if (_goals.Count != 0)
        {
            Console.WriteLine("The goals are:");

            for (int i = 0; i < _goals.Count; i++)
            {
                Goal goal = _goals[i];
                Console.WriteLine($"{i + 1}. {goal.Name}");
            }

            int input;

            do
            {
                Console.Write("What goal did you accomplish? ");
                input = int.Parse(Console.ReadLine());
            } while (input > _goals.Count);

            Goal selectedGoal = _goals[input - 1];
            int pointsEarned = selectedGoal.RecordEvent();

            selectedGoal.Spin();
            selectedGoal.DisplayProgressMessage();

            Console.WriteLine($"Congratulations! You have earned {selectedGoal.Point + selectedGoal.ExtraPoints} points!");
            selectedGoal.Spin();
            Console.WriteLine($"You now have {GetTotalScore()} points.");
        }
        else
        {
            Console.WriteLine("Please add a goal before attempting to record.\n");
            menu.DisplayMenu();
        }
    }

    public void SaveGoals()
    {
        if (_goals.Count != 0)
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(GetTotalScore());

                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine($"{goal.GetType().Name}: {goal.SaveGoalDetails()}");
                }
            }
        }
        else
        {
            Console.WriteLine("Please add a goal before attempting to save.\n");
            menu.DisplayMenu();
        }
    }

    public void LoadGoals(string filename)
    {
        Console.Write("What is the filename for the goal file? ");

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
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        SimpleGoal simpleGoal = new SimpleGoal();
        EternalGoal eternalGoal = new EternalGoal();
        ChecklistGoal checklistGoal = new ChecklistGoal();
        ProgressionGoal progressionGoal = new ProgressionGoal();
        GoalTracker trackGoal = new GoalTracker();

        int userInput;

        do
        {
            Console.WriteLine($"\nYou have {trackGoal.GetTotalScore()} points.\n");

            menu.DisplayMenu();
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                int prompt;

                do
                {
                    trackGoal.DisplayGoalTypes();
                    prompt = int.Parse(Console.ReadLine());

                    switch (prompt)
                    {
                        case 1:
                            simpleGoal.DisplayStartMessage();
                            trackGoal.AddGoal(simpleGoal);
                            break;
                        case 2:
                            eternalGoal.DisplayStartMessage();
                            trackGoal.AddGoal(eternalGoal);
                            break;
                        case 3:
                            checklistGoal.DisplayStartMessage();
                            trackGoal.AddGoal(checklistGoal);
                            break;
                        case 4:
                            progressionGoal.DisplayStartMessage();
                            trackGoal.AddGoal(progressionGoal);
                            break;
                        default:
                            Console.WriteLine("Invalid Selection.");
                            continue;
                    }
                } while (prompt < 4);
            }
            else if (userInput == 2)
            {
                trackGoal.DisplayGoals();
            }
            else if (userInput == 3)
            {
                trackGoal.SaveGoals();
            }
            else if (userInput == 4)
            {
                trackGoal.LoadGoals(Console.ReadLine());
            }
            else if (userInput == 5)
            {
                trackGoal.RecordGoal();
            }
            else
            {
                Console.WriteLine("Thanks for using our goal tracking software!");
            }
        } while (userInput < 6);
    }
}

/*
EXTRA REQUIREMENTS

1. I added a new ProgressionGoal class that rewards a user with bonusPoints when he attains a new level, and also when he completes the entire goal levels.
*/
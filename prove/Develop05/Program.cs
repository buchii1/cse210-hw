using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        SimpleGoal simpleGoal = new SimpleGoal();
        EternalGoal eternalGoal = new EternalGoal();
        ChecklistGoal checklistGoal = new ChecklistGoal();
        GoalTracker trackGoal = new GoalTracker();

        int userInput;

        do
        {
            Console.WriteLine($"\nYou have {trackGoal.GetTotalScore()} points.\n");

            menu.DisplayMenu();
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                menu.DisplayGoalTypes();
                int prompt = int.Parse(Console.ReadLine());

                if (prompt == 1)
                {
                    simpleGoal.DisplayStartMessage();
                    trackGoal.AddGoal(simpleGoal);
                }
                else if (prompt == 2)
                {
                    eternalGoal.DisplayStartMessage();
                    trackGoal.AddGoal(eternalGoal);
                }
                else
                {
                    checklistGoal.DisplayStartMessage();
                    trackGoal.AddGoal(checklistGoal);
                }
            }
            else if (userInput == 2)
            {
                trackGoal.DisplayGoals();
            }
            else if (userInput == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                trackGoal.SaveGoals(fileName);
            }
            else if (userInput == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                trackGoal.LoadGoals(fileName);
            }
            else if (userInput == 5)
            {
                trackGoal.RecordGoal();
            }
            else
            {
                Console.WriteLine("Thanks for using our app!");
            }
        } while (userInput < 6);
    }
}
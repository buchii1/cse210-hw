using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _questions = new List<string>()
        {
            "Who are the people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "Who is your role model and why?"
        };

    private List<string> _usedPrompts = new List<string>();
    private bool _questionsLeft;

    public ListingActivity()
    {
        _questionsLeft = true;

        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life " +
                      "by having you list as many things as you can in a certain area.";
    }

    private string GetRandomQuestion()
    {
        int questionsLength = _questions.Count;
        Random randGen = new Random();
        string text = null;

        if (questionsLength != 0)
        {
            int index = randGen.Next(questionsLength);
            text = _questions[index];

            _usedPrompts.Add(text);
            _questions.RemoveAt(index);
        }
        else
        {
            _usedPrompts.Clear();
            _questionsLeft = false;
        }

        return text;
    }

    public void RunActivity()
    {
        int counter = 0;
        
        DisplayStartMessage();
        Duration = int.Parse(Console.ReadLine());
        ClearConsole();

        Console.WriteLine("Get ready...");
        Spin();
        Console.WriteLine();

        if (_questionsLeft)
        {
            Console.WriteLine("List as many responses you can to the following prompts:");
            Console.Write("--- ");
            Console.Write(GetRandomQuestion());
            Console.Write(" ---");

            Console.WriteLine();
            Console.Write("You may begin in: ");
            CountDown();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(Duration);

            while (DateTime.Now < endTime)
            {
                string text = Console.ReadLine();
                counter++;
            }

            Console.WriteLine($"You listed {counter} items!\n");
            DisplayEndMessage();
            ClearConsole();
        }
        else
        {
            Console.WriteLine("No more questions for today.");
            ClearConsole();
        }
    }
}
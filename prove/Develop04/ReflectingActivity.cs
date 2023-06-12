using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you were extremely proud of yourself."
        };

    private List<string> _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "How can you keep this experience in mind in the future?"
        };

    private List<string> _usedPrompts = new List<string>();
    private bool _promptLeft;
    private int _spinDuration;


    public ReflectingActivity()
    {
        _promptLeft = true;
        _spinDuration = 10;

        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown " +
                      "strength and resilience. This will help you recognize the power you have and how " +
                      "you can use it in other aspects of your life.";
    }

    private string GetRandomPrompt(List<string> newList)
    {
        int promptLength = newList.Count;
        Random randGen = new Random();
        string text = null;

        if (promptLength != 0)
        {
            int index = randGen.Next(promptLength);
            text = newList[index];

            _usedPrompts.Add(text);
            newList.RemoveAt(index);
        }
        else
        {
            _usedPrompts.Clear();
            _promptLeft = false;
        }

        return text;
    }

    public void RunActivity()
    {
        DisplayStartMessage();
        Duration = int.Parse(Console.ReadLine());
        ClearConsole();

        Console.WriteLine("Get ready...");
        Spin();
        Console.WriteLine();

        if (_promptLeft)
        {
            Console.WriteLine("Consider the following prompt:\n");
            Console.Write("--- ");
            Console.Write(GetRandomPrompt(_prompts));
            Console.Write(" ---");
        }
        else
        {
            Console.WriteLine("No more prompts for today.");
        }

        Console.WriteLine("\n\nWhen you have something in mind, press enter to continue.");
        string userInput = Console.ReadLine();

        if (userInput == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
            Console.Write("You may begin in: ");
            CountDown();
            ClearConsole();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(Duration);

            while (DateTime.Now < endTime)
            {
                if (_promptLeft)
                {
                    Console.Write($"{GetRandomPrompt(_questions)} ");
                    Spin(_spinDuration);
                }
                else
                {
                    Console.Write("No more questions for the chosen prompt.\n");
                    break;
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            DisplayEndMessage();
            ClearConsole();
        };
    }
}
public class BreathingActivity : Activity
{
    private int _interval;
    private int _breathInDuration;
    private int _breathOutDuration;

    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing " +
                     "in and out slowly. Clear your mind and focus on your breathing.";

        _interval = 10;
        _breathInDuration = (int)((60.0 / 100.0) * _interval);
        _breathOutDuration = (int)((40.0 / 100.0) * _interval);
    }

    private void BreathIn()
    {
        Console.Write("Breathe in...");
        CountDown(_breathInDuration);
    }

    private void BreathOut()
    {
        Console.Write("Now breathe out...");
        CountDown(_breathOutDuration);
    }

    public void RunActivity()
    {
        DisplayStartMessage();
        Duration = int.Parse(Console.ReadLine());
        ClearConsole();

        Console.WriteLine("Get ready...");
        Spin();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            BreathIn();
            BreathOut();
            Console.WriteLine();
        }

        DisplayEndMessage();
        ClearConsole();
    }
}
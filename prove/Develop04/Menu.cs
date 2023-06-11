public class Menu
{
    private List<string> _prompts = new List<string>();

    public Menu()
    {
        _prompts.Add("Start breathing activity");
        _prompts.Add("Start reflecting activity");
        _prompts.Add("Start listing activity");
        _prompts.Add("Quit");
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");

        for (int i = 0; i < _prompts.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_prompts[i]}");
        }

        Console.Write("Select a choice from the menu: ");
    }
}
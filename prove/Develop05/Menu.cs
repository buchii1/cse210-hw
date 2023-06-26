public class Menu
{
    private List<string> _menuOptions;
    private List<string> _goalTypes;

    public Menu()
    {
        _menuOptions = new List<string>
        {
            "Create New Goal",
            "List Goals",
            "Save Goals",
            "Load Goals",
            "Record Event",
            "Quit"
        };

        _goalTypes = new List<string>
        {
            "Simple Goal",
            "Eternal Goal",
            "Checklist Goal"
        };
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");

        for (int i = 0; i < _menuOptions.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_menuOptions[i]}");
        }

        Console.Write("Select a choice from the menu: ");
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
}

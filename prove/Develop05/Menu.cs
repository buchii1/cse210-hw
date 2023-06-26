public class Menu
{
    private List<string> _menuOptions;

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
}

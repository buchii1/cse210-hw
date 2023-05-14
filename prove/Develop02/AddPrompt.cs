public class AddPrompt
{
    public string _prompt;

    public void AddNewPrompt()
    {
        Console.WriteLine("Add a new question prompt:");
        _prompt = Console.ReadLine();
    }
}
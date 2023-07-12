public class Comment
{
    public string _name;
    public string _text;

    public void DisplayComment()
    {
        Console.WriteLine($"Name: {_name} - Comment: {_text}");
    }
}
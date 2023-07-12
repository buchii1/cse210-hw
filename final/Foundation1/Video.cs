public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public Video()
    {
        _comments = new List<Comment>();
    }

    public int TotalComments()
    {
        return _comments.Count();
    }

    public void DisplayComments()
    {
        Console.WriteLine("Comments:");

        foreach (Comment text in _comments)
        {
            text.DisplayComment();
        }
    }

    public void DisplayVideo()
    {
        Console.Write($"Video url: {_title}\nAuthor: {_author}\nDuration: {_length}s - ");
    }
}
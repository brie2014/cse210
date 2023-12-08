public class Video
{
    private string _title;
    private string _author;
    private int _length; // in seconds
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new();

    }

    public int GetNumberOfComments()
    {
        return _comments.Count();
    }

    public void AddComment(string personName, string text)
    {
        var newComment = new Comment(personName, text);
        _comments.Add(newComment);
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} by {_author} ({_length} seconds)");
        Console.WriteLine($"Comments ({GetNumberOfComments()})");
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            var displayText = comment.GetDisplayString();
            Console.WriteLine($"~{displayText}");
        }
    }

}
public class Comment
{
    private string _personName;
    private string _text;

    public Comment(string personName, string text)
    {
        _personName = personName;
        _text = text;

    }

    public string GetDisplayString()
    {
        return $"{_personName}: {_text}";
    }

}
using System;

class Reference
{
    // Attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Methods
    public string GetDisplayText()
    {
        var baseDisplayText = $"{_book} {_chapter}:{_verse}";
        if (_endVerse > 0)
        {
            return $"{baseDisplayText}-{_endVerse}";
        }
        return baseDisplayText;
    }

}

using System;

class Word
{
    // Attributes
    private string _text;
    private bool _isHidden;

    // Constructors
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Methods
    public void Hide()
    {
        _isHidden = true;

    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string replacedString = new String(_text.Select(l => '_').ToArray());
            return replacedString;
        }
        return _text;
    }

}

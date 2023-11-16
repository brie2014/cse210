using System;

class Scripture
{
    // Attributes
    private Reference _reference;
    private List<Word> _words;

    // Constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        _words = new();
        foreach (string word in words)
        {
            Word wordObject = new(word);
            _words.Add(wordObject);
        }

    }

    //Methods
    public void HideRandomWords(int numberToHide)
    {
        // generate x amount of random numbers
        Random r = new();
        var randomNumbers = Enumerable.Range(0, _words.Count).OrderBy(x => r.Next()).Take(numberToHide);
        // set hide property on the words at those indices
        foreach (int randomNumber in randomNumbers)
        {
            _words[randomNumber].Hide();
        }

    }
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string scriptureString = "";
        foreach (Word word in _words)
        {
            scriptureString += word.GetDisplayText() + " ";
        }
        return $"{referenceText} {scriptureString}";



    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;

    }

}

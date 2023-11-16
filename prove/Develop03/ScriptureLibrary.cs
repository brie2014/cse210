using System;

class ScriptureLibrary
{
    // Attributes
    private readonly List<Scripture> _scriptureList = new();
    private readonly Random _rnd = new();

    // Constructors
    public ScriptureLibrary()
    {
        Reference reference1 = new("John", 14, 15);
        Scripture scripture1 = new(reference1, "If ye love me, keep my commandments.");

        Reference reference2 = new("Moses", 1, 39);
        Scripture scripture2 = new(reference2, "For behold, this is my work and glory to bring to pass the immortality and eternal life of man.");

        Reference reference3 = new("James", 1, 5, 6);
        Scripture scripture3 = new(reference3, "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");

        _scriptureList.Add(scripture1);
        _scriptureList.Add(scripture2);
        _scriptureList.Add(scripture3);
    }


    //Methods
    public Scripture GetRandomScripture()
    {
        int num = _rnd.Next(0, _scriptureList.Count);
        var myScripture = _scriptureList[num];
        return myScripture;

    }

}

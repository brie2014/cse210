using System;

class Program
{
    static void Main()
    {
        ScriptureLibrary myScriptureLibrary = new();
        var myScripture = myScriptureLibrary.GetRandomScripture();

        var userInput = "start";
        var wordsToHide = 0;
        while (userInput != "quit")
        {
            // Clear the console, hide random words, and show the scripture
            Console.Clear();
            myScripture.HideRandomWords(wordsToHide);
            Console.WriteLine(myScripture.GetDisplayText());

            // Get user input if the scripture is not totally hidden
            Console.Write("Press enter to continue or type 'quit' to finish ");
            if (myScripture.IsCompletelyHidden()) return;
            userInput = Console.ReadLine();

            // Increment how many words to hide for the next loop
            wordsToHide += 3;

        }

    }
}
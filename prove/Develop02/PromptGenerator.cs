using System;

class PromptGenerator
{
    private List<string> _prompts = new List<string>(){
        "What was your day like?",
        "How did you help someone today?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was one thing that went great today?",
        "What was the weirdest thing that happened today?",
        "Talk about some of your current favorite things (music, food, shows, etc.)",
        "What is one goal you have and what are you doing to accomplish it?",
        "If you had to describe your day in a flavor, what would it be?",
        "Who is someone you respect and why?",
        "What is something you are grateful for and why?"
    };
    public string GetRandomPrompt()
    {
        // Generate random number
        Random rnd = new Random();
        int num = rnd.Next(0, _prompts.Count());
        // Access prompt at the index of that random number
        string randomPrompt = _prompts[num];
        return randomPrompt;
    }

    // add prompt method for full credit
}
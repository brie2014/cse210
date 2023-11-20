public class ReflectingActivity : Activity
{
    // Attributes
    private List<string> _prompts = new() {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

    private List<string> _questions = new() {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };

    //Constructors 
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    //Methods
    public void Run()
    {
        DisplayStartingMessage();
        // Show random prompt
        DisplayPrompt();
        // Have user press enter when ready
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue");
        Console.ReadLine();

        // Give instructions
        Console.WriteLine("Now ponder on each of the following questions as they related to that experince.");
        Console.WriteLine();

        // Countdown to start
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Keep showing questions until specified time has passed
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        // Generate random number
        Random rnd = new Random();
        int num = rnd.Next(0, _prompts.Count);
        // Access prompt at the index of that random number
        string randomPrompt = _prompts[num];
        return randomPrompt;

    }

    public string GetRandomQuestion()
    {
        // Generate random number
        Random rnd = new Random();
        int num = rnd.Next(0, _questions.Count);
        // Access prompt at the index of that random number
        string randomPrompt = _questions[num];
        return randomPrompt;

    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        var promptToDisplay = GetRandomPrompt();
        Console.WriteLine($"--- {promptToDisplay} ---");

    }
    public void DisplayQuestion()
    {
        // After each question the program should pause and show a spinner for several seconds
        var questionToDisplay = GetRandomQuestion();
        Console.WriteLine();
        Console.Write($"> {questionToDisplay}");
        ShowSpinner(10);
    }
}

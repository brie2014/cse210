public class ListingActivity : Activity
{
    // Attributes
    private int _count = 0;
    private List<string> _prompts = new() {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

    //Constructors 
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    //Methods
    public void Run()
    {
        DisplayStartingMessage();
        // Show random prompt
        DisplayPrompt();

        // Give countdown of several seconds to think about prompt
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.WriteLine();

        // List as many items as you can in duration
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Keep showing questions until specified time has passed
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            // Keep track of number of items
            _count++;
        }
        // Display number of items
        Console.WriteLine($"You listed {_count} items!");
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

    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        var promptToDisplay = GetRandomPrompt();
        Console.WriteLine($"--- {promptToDisplay} ---");
    }
}

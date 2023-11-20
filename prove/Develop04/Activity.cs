public class Activity
{
    //Attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    //Constructors
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 60;
    }
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //Methods
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like to do this activity? ");
        var newDuration = Convert.ToInt32(Console.ReadLine());
        _duration = newDuration;

        // Clear console so it is fresh for the activity
        Console.Clear();
        Console.WriteLine();
        Console.Write("Get ready...");
        ShowCountDown(3);
        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        // Show messages and pause for a few seconds before ending
        Console.WriteLine("Well done!");
        ShowSpinner(5);

        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
        ShowSpinner(5);

    }
    public void ShowSpinner(int seconds)
    {
        var spinnerChars = new List<char>(){
          '|', '/', '-', '\\', '|', '/', '-', '\\'
        };
        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            char spinChar = spinnerChars[i];
            Console.Write(spinChar);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= spinnerChars.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (var i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
}

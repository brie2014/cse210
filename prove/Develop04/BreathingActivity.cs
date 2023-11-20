public class BreathingActivity : Activity
{
    //Constructors 
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    //Methods
    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Keep going until specified time has passed
        while (DateTime.Now < endTime)
        {
            Random rnd = new Random();
            // Show alternating breathe in and breathe out messages.After each message, pause and show a countdown
            int secondsToBreathe = rnd.Next(3, 6);

            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(secondsToBreathe);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(secondsToBreathe);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}

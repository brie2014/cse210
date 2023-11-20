using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App");

        //Set goals
        var totalTime = 0;
        var totalExercises = 0;
        Goals goals = new();
        goals.SetGoals();

        string userChoice = "start";
        while (userChoice != "4")
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness App");
            goals.CheckGoals(totalTime, totalExercises);
            ShowMenu();
            userChoice = Console.ReadLine();
            switch (userChoice)
            {
                // Breathing Activity
                case "1":
                    BreathingActivity breathingActivity = new();
                    breathingActivity.Run();
                    totalExercises++;
                    totalTime += breathingActivity.GetDuration();
                    break;
                // Reflecting Activity
                case "2":
                    ReflectingActivity reflectingActivity = new();
                    reflectingActivity.Run();
                    totalExercises++;
                    totalTime += reflectingActivity.GetDuration();
                    break;
                // Listing Activity
                case "3":
                    ListingActivity listingActivity = new();
                    listingActivity.Run();
                    totalExercises++;
                    totalTime += listingActivity.GetDuration();
                    break;
                // Quit
                case "4":
                    Console.WriteLine("Thanks for using practicing mindfulness. Come back soon!");
                    return;
                default:
                    Console.WriteLine("Please enter a valid choice");
                    ShowMenu();
                    break;
            }
        }
    }
    static void ShowMenu()
    {
        Console.WriteLine("Please select one of the following choices.");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("What would you like to do? ");

    }
}
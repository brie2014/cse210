using System.Text.Json;
public class GoalManager
{

    private List<Goal> _goals;

    private int _score;

    public GoalManager()
    {
        _goals = new();
        _score = 0;
    }

    public void Start()
    {
        string userChoice = "start";
        while (userChoice != "6")
        {
            DisplayPlayerInfo();
            ShowMenu();
            userChoice = Console.ReadLine();
            switch (userChoice)
            {
                // Create New Goal
                case "1":
                    CreateGoal();
                    break;
                // List Goals
                case "2":
                    ListGoalDetails();
                    break;
                // Save Goals
                case "3":
                    SaveGoals();
                    break;
                // Load Goals
                case "4":
                    LoadGoals();
                    break;
                // Record Event
                case "5":
                    RecordEvent();
                    break;
                // Quit
                case "6":
                    Console.WriteLine("Thanks for using Eternal Quest. Come back soon!");
                    return;
                default:
                    break;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
    }
    public void ListGoalDetails()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete())
            {
                Console.WriteLine($"{i}. [X] {goal.GetDetailsString()}");
            }
            else
            {
                Console.WriteLine($"{i}. [ ] {goal.GetDetailsString()}");
            }

            i++;
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        var goalChoice = Console.ReadLine();


        Console.Write("What is the name of your goal? ");
        var name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        var description = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        var points = Convert.ToInt32(Console.ReadLine());

        switch (goalChoice)
        {
            // Simple Goal
            case "1":
                SimpleGoal simpleGoal = new(name, description, points);
                _goals.Add(simpleGoal);
                break;
            // Eternal Goal
            case "2":
                EternalGoal eternalGoal = new(name, description, points);
                _goals.Add(eternalGoal);
                break;
            // Checklist Goal
            case "3":
                Console.Write("How many times does this goal have to be completed for a bonus? ");
                var target = Convert.ToInt32(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing the goal that many times? ");
                var bonus = Convert.ToInt32(Console.ReadLine());
                ChecklistGoal checklistGoal = new(name, description, points, target, bonus);
                _goals.Add(checklistGoal);
                break;
        }


    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        var goalIndex = Convert.ToInt32(Console.ReadLine()) - 1;
        _goals[goalIndex].RecordEvent();
    }
    public void SaveGoals()
    {
        // Get filename from user
        Console.Write("Please enter the name of the file to save to: ");
        string fileName = Console.ReadLine();

        // Verify if they want to overwrite contents if file exists
        if (File.Exists(fileName))
        {
            Console.WriteLine("That file already exists. Would you like to overwrite it's contents?");
            Console.Write("Please enter y or n to continue: ");
            string confirmSave = Console.ReadLine();
            if (confirmSave != "y")
            {
                Console.WriteLine("File was not saved");
                return;
            }
        }

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.Write(JsonSerializer.Serialize(_goals));
        }
    }
    public void LoadGoals()
    {
        // Get filename from user
        Console.Write("Please enter the name of the file to load: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("That file does not exist.");
            return;
        }
        // Read from JSON file;
        string jsonString = File.ReadAllText(fileName);

        // Deserialize json back to a list of entries and set the entries to the loaded value
        _goals = JsonSerializer.Deserialize<List<Goal>>(jsonString)!;
    }
}
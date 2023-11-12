using System;

class Program
{
    static void Main()
    {
        Journal journal = new();
        PromptGenerator promptGenerator = new();

        Console.WriteLine("Welcome to the Journal Program");
        string userChoice = "start";
        while (userChoice != "5")
        {
            ShowMenu();
            userChoice = Console.ReadLine();
            switch (userChoice)
            {
                // Write
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.Write(prompt);
                    string userResponse = Console.ReadLine();
                    Entry newEntry = new()
                    {
                        Date = DateTime.Now.ToString("MM/dd/yyyy"),
                        PromptText = prompt,
                        EntryText = userResponse,
                    };
                    journal.AddEntry(newEntry);
                    break;
                // Display
                case "2":
                    journal.DisplayAll();
                    break;
                // Load
                case "3":
                    journal.LoadFromFile();
                    break;
                // Save
                case "4":
                    journal.SaveToFile();
                    break;
                // Quit
                case "5":
                    Console.WriteLine("Thanks for using Journal App. Come back soon!");
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
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do?");

    }
}
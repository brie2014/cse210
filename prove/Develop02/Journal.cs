using System;
using System.IO;
using System.Text.Json;

class Journal
{
    public List<Entry> Entries { get; set; } = new();
    public void AddEntry(Entry newEntry)
    {
        Entries.Add(newEntry);

    }
    public void DisplayAll()
    {
        // Display message if no entries exist
        if (Entries.Count < 1)
        {
            Console.WriteLine("There are currently no entries to display.");
            return;
        }

        foreach (Entry entry in Entries)
        {
            entry.Display();
        }

    }
    public void SaveToFile()
    {
        // Get filename from user
        Console.Write("Please enter the name of the file to save: ");
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
            outputFile.Write(JsonSerializer.Serialize(Entries));
        }

    }
    public void LoadFromFile()
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
        Entries = JsonSerializer.Deserialize<List<Entry>>(jsonString)!;

    }
}
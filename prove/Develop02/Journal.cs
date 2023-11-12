using System;
using System.IO;

class Journal
{
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }
    public void DisplayAll()
    {
        // Display message if no entries exist
        Console.WriteLine(_entries.Count);
        if (_entries.Count < 1)
        {
            Console.WriteLine("There are currently no entries to display.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }
    public void SaveToFile()
    {
        // used to confirm
        string confirmSave = "y";

        // Get filename from user
        Console.Write("Please enter the name of the file to save: ");
        string fileName = Console.ReadLine();

        // Verify if they want to overwrite contents if file exists
        if (File.Exists(fileName))
        {
            Console.WriteLine("That file already exists. Would you like to overwrite it's contents?");
            Console.Write("Please enter y or n to continue: ");
            confirmSave = Console.ReadLine();
            if (confirmSave != "y")
            {
                Console.WriteLine("File was not saved");
                return;
            }
        }

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }

    }
    public void LoadFromFile()
    {
        // Reset list so we can overwrite it (per project specifications)
        _entries = new List<Entry>();

        // Get filename from user
        Console.Write("Please enter the name of the file to load: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("That file does not exist.");
            return;
        }

        // Read each line from the file (each line should be an entry)
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            // Parse out the entry parts from each line
            string[] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            // Recreate Entry object
            Entry loadedEntry = new Entry()
            {
                _date = date,
                _promptText = prompt,
                _entryText = entry,
            };

            // Add Entry to Journal
            _entries.Add(loadedEntry);

        }


    }
}
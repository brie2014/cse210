using System;

class Program
{
    static void Main()
    {
        var _events = new List<Event>();

        DateTime lectureDate = DateTime.Parse("08/21/2024");
        Address lectureAddress = new("925 Viking Lane", "Berk", "Vikington", "Iceland");
        Lecture lecture = new("How to Train Dragons", "Learn how to wrangle and manage your own personal dragon", lectureDate, "7:36PM", lectureAddress, "Hiccup", 27);
        _events.Add(lecture);

        DateTime receptionDate = DateTime.Parse("02/11/2024");
        Address receptionAddress = new("12 Knit Drive", "Smithton", "Alberta", "Canada");
        Reception reception = new("Goodies with Grandmas and Goats", "Come enjoy a variety of goodly goodies with your grandma, or your goat!", receptionDate, "12:04PM", receptionAddress, "gwg@GOAT.com");
        _events.Add(reception);


        DateTime outdoorGatheringDate = DateTime.Parse("12/26/2023");
        Address outdoorGatheringAddress = new("111 Claus Street", "North Pole", "Alaska", "United States");
        OutdoorGathering outdoorGathering = new("North Pole Party", "Time to celebrate a successful Christmas Eve delivery when Santa returns! Bring your own cocoa!", outdoorGatheringDate, "4:00AM", outdoorGatheringAddress, "Snowy with a chance of more snow. Temperatures well below freezing.");
        _events.Add(outdoorGathering);

        foreach (Event e in _events)
        {
            Console.WriteLine("-------------Short Description-------------");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("-------------Standard Details-------------");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine("-------------Full Details-------------");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
        }


    }
}
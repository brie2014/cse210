using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base Assignment object
        Assignment assignment1 = new("Dwight Schrute", "Beet Farming Info");
        var summary1 = assignment1.GetSummary();
        Console.WriteLine(summary1);

        // Create a dervied MathAssignment object
        MathAssignment assignment2 = new("Michael Scott", "Division", "7.2", "1-20");
        var mathSummary = assignment2.GetSummary();
        var mathHomeworkList = assignment2.GetHomeworkList();
        Console.WriteLine(mathSummary);
        Console.WriteLine(mathHomeworkList);

        // Create a dervied WritingAssignment object
        WritingAssignment assignment3 = new("James Trickington", "Formal Etiquette", "How to Throw a Dinner Party");
        var writingSummary = assignment3.GetSummary();
        var writingInformation = assignment3.GetWritingInformation();
        Console.WriteLine(writingSummary);
        Console.WriteLine(writingInformation);
    }
}
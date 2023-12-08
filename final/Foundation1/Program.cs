using System;

class Program
{
    static void Main()
    {
        // Make videos and add comments;
        Video video1 = new("Garden Party 101", "James Trickington", 305);
        video1.AddComment("Dwight Schrute", "Thanks for helping me get started in the garden party business!");
        video1.AddComment("Jim Halpert", "Wow, this guy is a genius!");
        video1.AddComment("Andy Bernard", "I want a garden party now!");

        Video video2 = new("Shoot for the Stars: A Guide to Space Warfare", "Emperor Palpatine", 406);
        video2.AddComment("Stormtrooper", "Tried this advice--still can't hit anything");
        video2.AddComment("Yoda", "No real power, the darkside has");
        video2.AddComment("Anakin Skywalker", "Wish I would have seen this sooner...");


        Video video3 = new("Coding for Advanced Noobs", "Calvin Newbie", 973);
        video3.AddComment("John Doe", "Greatest video ever!");
        video3.AddComment("Jane Doe", "This video got me promoted to senior intern!");
        video3.AddComment("Doe Adeer", "Love this guy!");

        // Put videos in a list
        var videos = new List<Video>() { video1, video2, video3 };

        // Display details and comments about each video
        foreach (Video video in videos)
        {
            video.DisplayVideo();
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}
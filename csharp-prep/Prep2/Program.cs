using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        char letter;
        if (grade < 60)
        {
            letter = 'F';
        }
        else if (grade < 70)
        {
            letter = 'D';
        }
        else if (grade < 80)
        {
            letter = 'C';
        }
        else if (grade < 90)
        {
            letter = 'B';
        }
        else
        {
            letter = 'A';
        }
        Console.WriteLine($"Your grade is: {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}
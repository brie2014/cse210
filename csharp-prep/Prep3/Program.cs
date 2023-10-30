using System;

class Program
{
    static void Main(string[] args)
    {
        bool wantsToPlay = true;
        while (wantsToPlay)
        {
            // Generate random number
            Random rand = new Random();
            int magicNumber = rand.Next(0, 101);
            int guess;
            // Variable to track guesses
            int guesses = 0;
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesses++;
                if (guess == magicNumber)
                {
                    Console.WriteLine($"You guessed it! It took you {guesses} guesses");
                }
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
            } while (guess != magicNumber);

            // Ask if user wants to play again
            Console.Write("Do you want to play again (y or n)?");
            string userInput = Console.ReadLine();
            wantsToPlay = userInput == "y";
        }

    }
}
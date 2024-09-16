using System;

class RockPaperScissors
{
    static void Main()
    {
        // Initialize player and computer scores to 0
        int userScore = 0;
        int computerScore = 0;
        Random random = new Random(); // Random object for generating computer's choice

        // Welcome message and game objective
        Console.WriteLine("Welcome to Rock, Paper, Scissors!");
        Console.WriteLine("First to 5 points wins!");
    }
}
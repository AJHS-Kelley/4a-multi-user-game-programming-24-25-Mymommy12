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

        // Loop until either the user or the computer reaches 5 points
        while (userScore < 5 && computerScore < 5)
        {
            // Prompt the user for their choice
            Console.WriteLine("\nEnter your choice: Rock, Paper, or Scissors:");
            string userChoice = Console.ReadLine().ToUpper(); // Convert user input to uppercase for easier comparison

            // Validate user input (ensure they entered Rock, Paper, or Scissors)
            while (userChoice != "ROCK" && userChoice != "PAPER" && userChoice != "SCISSORS")
            {
                Console.WriteLine("Invalid choice. Please choose Rock, Paper, or Scissors:");
                userChoice = Console.ReadLine().ToUpper(); // Keep asking until a valid choice is entered
            }

            // Generate the computer's choice using a random selection
            string computerChoice = GetComputerChoice(random);
            Console.WriteLine("Computer chose: {computerChoice}");

            // Determine the winner of the round (Player, Computer, or Tie)
            string result = DetermineWinner(userChoice, computerChoice);

            // Update scores based on the round result
            if (result == "Player")
            {
                userScore++; // Increment user score if player wins
                Console.WriteLine("You win this round!");
            }
            else if (result == "Computer")
            {
                computerScore++; // Increment computer score if computer wins
                Console.WriteLine("Computer wins this round!");
            }
            else
            {
                Console.WriteLine("It's a tie! No points awarded.");
            }

            // Display the current score after each round (Just a little easter egg this work was done by Kenedy Davis)
            Console.WriteLine("\nScore: You: {userScore} | Computer: {computerScore}");
        }

        // Declare the final winner based on who reached 5 points first
        if (userScore == 5)
        {
            Console.WriteLine("\nCongratulations! You are the winner!");
        }
        else
        {
            Console.WriteLine("\nComputer wins the game! Better luck next time.");
        }
    }

    // Method to randomly select the computer's choice
    static string GetComputerChoice(Random random)
    {
        string[] choices = { "ROCK", "PAPER", "SCISSORS" }; // Available options
        return choices[random.Next(choices.Length)]; // Randomly select one of the three options
    }

    // Method to determine the winner based on player and computer choices
    static string DetermineWinner(string userChoice, string computerChoice)
    {
        // If both choices are the same, it's a tie
        if (userChoice == computerChoice)
        {
            return "Tie";
        }
        // Check if the player wins based on game rules
        else if ((userChoice == "ROCK" && computerChoice == "SCISSORS") ||
                 (userChoice == "PAPER" && computerChoice == "ROCK") ||
                 (userChoice == "SCISSORS" && computerChoice == "PAPER"))
        {
            return "Player"; // Player wins
        }
        else
        {
            return "Computer"; // Computer wins (Sadly)
        }
    }
}
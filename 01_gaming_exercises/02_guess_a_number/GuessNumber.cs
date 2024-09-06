using System;
class GuessNumber {
  static void Main() {
    int numGuess = 0;
    int maxGuess = 100;
    int guess;
    // Generate the secret number here.
    Random rnd = new Random(); // Create and object named 'rnd' that is a copy of the Random() class.
    int secretNumber = rnd.Next(101); // Generate from 0 to 100
    Console.WriteLine(secretNumber); // COMMENT OUT AFTER TESTING
    // int secretNumber = rnd.Next(25, 1001);  Generate from 25 to 1000
    
    while (numGuess < maxGuess)
    {
       Console.WriteLine("Please guess an integer between 0 and 100.\n");
       guess = Convert.ToInt32(Console.ReadLine());
       //Console.WriteLine("Guess" + guess);
       
       numGuess++;
       if (guess < secretNumber)
       {
          Console.WriteLine("Your guess is too low Dumb[curse word].\n");
       }
       else if (guess > secretNumber)
       {
          Console.WriteLine("Your guess is too high Dumb[curse word].\n");
       }
       else 
       {
          Console.WriteLine("You're not useless afterall.. You guessed correctly.\n");
          break; // Keyword to immediatley exit a loop.
       }
       if (numGuess >= maxGuess)
       {
           Console.WriteLine("You have lost the game.\nYour grandparents are disappointed in you.\n");
       }
    }

      // Allow the user to guess the number. (Done)
      //Compare the guess to the secret number. (Done)
      // If match, print win, if > or <, give a hint. (Done)
      // +1 to numGuess (Done)
      // Check if numgues > maxGuesses. (Done)
      // If true, print a "lose game" message, if false guess again. (Done)



  }
}
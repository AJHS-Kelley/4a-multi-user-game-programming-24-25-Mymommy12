
 using System;

 class Template {
 static void Main() {
 // PLAYER VARIABLES
 string playerName = "Test Player";
 int playerScore = 0;
 string playerChoice = "";

 // CPU VARIABLES 
 int cpuScore = 0;
 string cpuChoice = "";
	 
 // TESTING GAME LOOP
int loopCount = 0;
	 int numDraws = 0;
int loopReqs = 0; // Req / Reqs is universal abbrv. for REQUEST / Requests
Console.WriteLine("How many loops do you need?\nType an INTEGER and press ENNTER.\n");
loopReqs = Convert.ToInt32(Console.ReadLine());

 while (loopCount < loopReqs)
 { 
 // Allow CPU to select randomly. 
 Random rnd = new Random();
 int cpuRand = rnd.Next(0, 2);

 if (cpuRand == 0)
 {
 cpuChoice = "rock";
 }
 else if (cpuRand == 1)
 {
 cpuChoice = "paper";
 }
 else if (cpuRand == 2)
 {
 cpuChoice = "scissors";
 }
 else
 { 
 Console.WriteLine("Unable to determine CPU choice.\n");
 }
 Console.WriteLine("CPU Choice" + cpuChoice);
 
  // Allow PLAYER to select randomly. 
 int playerRand = rnd.Next(0, 2);

 if (playerRand == 0)
 {
 playerChoice = "rock";
 }
 else if (playerRand == 1)
 {
 playerChoice = "paper";
 }
 else if (playerRand == 2)
 {
 playerChoice = "scissors";
 }
 else
 { 
 Console.WriteLine("Unable to determine Player choice.\n");
 }

 // Compare the two choices and determine a winner. 
 if (playerChoice == "rock" && cpuChoice == "paper")
 {
//
 cpuScore++;
 }
 else if (playerChoice == "rock" && cpuChoice == "scissors")
 {

 playerScore++;
 }
 else if (playerChoice == "rock" && cpuChoice == "rock")
 {
// Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 //Console.WriteLine("It's a draw!");
   numDraws++;
 }
 else if (playerChoice == "paper" && cpuChoice == "paper")
 {
 //Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 //Console.WriteLine("It's a draw!");
   numDraws++;
 }
 else if (playerChoice == "paper" && cpuChoice == "scissors")
 {
 //Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 //Console.WriteLine("The CPU wins.\n");
 cpuScore++;
 
 }
 else if (playerChoice == "paper" && cpuChoice == "rock")
 {
 //Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 //Console.WriteLine("You win!\n");
 playerScore++; 
 }
 else if (playerChoice == "scissors" && cpuChoice == "paper")
 {
 //Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 //Console.WriteLine("You win!\n");
 playerScore++; 
 }
 else if (playerChoice == "scissors" && cpuChoice == "scissors")
 {
 //Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 //Console.WriteLine("It's a draw!"); 
   numDraws++;
 }
 else if (playerChoice == "scissors" && cpuChoice == "rock")
 {
 //Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 //Console.WriteLine("The CPU wins.\n");
 cpuScore++; 
 } 
 loopCount++;
 }
 
 if (playerScore > cpuScore)
 {
 Console.WriteLine("Congratulations, you are the winner!\n"); 
 }
 else
 {
 Console.WriteLine("The CPU has defeated you.\n"); 
 }

  Console.WriteLine($"Player Score: {playerScore}\n");
  Console.WriteLine($"CPU Score: {cpuScore}\n");
  Console.WriteLine($"Draws: {numDraws}\n");
 }
}
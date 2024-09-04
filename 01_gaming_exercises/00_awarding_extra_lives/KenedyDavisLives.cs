//Code by Kenedy Davis
using System;

class Player
{
    int Lives { get; private set; }
    int Score { get; private set; }

    public Player()
    {
        Lives = 3; // Start with 3 lives
        Score = 0; // Score starts at 0
    }

    public void UpdateScore(int points)
    {
        Score += points;

        if (Score < 10000)
        {
            Lives--; // If under 10000, The user will loose a life
        }
        else if (Score >= 10001 && Score < 100000)
        {
            Lives++; // Gain 1 extra life If more then 10001, The user will gain 1 life
        }
        else if (Score >= 100000)
        {
            Lives += 2; // If more then 100000, The User will gain 2 extra lives
        }
   }
}
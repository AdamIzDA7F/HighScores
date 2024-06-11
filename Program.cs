
using System;

namespace HighScores
{

    class PlayerScore
    {
        private int score;
        public int Score
        {
            get { return score; }
            set
            {
                if (value >= 0)
                {
                    score = value;
                }
                else
                {
                  Console.WriteLine("Enter a positive score.");
                  score = 0;
                }
            }
        }
    }

    class Players
    {
   
        private string initials;
        public string Initials
        {
            get { return initials; }
            set
            {
                if (value.Length <= 3)
                {
                    initials = value.ToUpper();
                }
                else
                {
                Console.WriteLine("Initials should be 3 characters or less.");
                }
            }
        }
    }

    class Program
        {
            static void Main(string[] args)
            {
         
            Players player = new Players();
            Console.WriteLine("Enter Player Initials (up to 3 characters):");
           string Initials = Console.ReadLine();
            player.Initials = Initials;
            Console.WriteLine("Player's Initials: " + player.Initials);

            PlayerScore score = new PlayerScore();
            Console.Write("Enter your score: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int scores))
            {
             score.Score = scores;
             Console.WriteLine("New High Score: " + score.Score);
            }
            else
            {
            Console.WriteLine("Invalid score. Please enter a valid score. No Negatives");
            }
        }
    }
}

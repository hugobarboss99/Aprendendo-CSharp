using System;

namespace Joguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to the game!");

            // Initialize game variables
            int lives = 3;
            int score = 0;
            bool gameOver = false;

            // Game loop
            while (!gameOver)
            {
                // Display current lives and score
                Console.WriteLine("Lives: " + lives + " Score: " + score);

                // Get player input
                Console.Write("Enter a command: ");
                string input = Console.ReadLine();

                // Process player input
                if (input == "jump")
                {
                    Console.WriteLine("You jumped over the obstacle!");
                    score += 10;
                }
                else if (input == "duck")
                {
                    Console.WriteLine("You ducked under the obstacle!");
                    score += 5;
                }
                else if (input == "quit")
                {
                    Console.WriteLine("Thanks for playing!");
                    gameOver = true;
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                    lives--;
                }

                // Check if player has no more lives
                if (lives <= 0)
                {
                    Console.WriteLine("Game over!");
                    gameOver = true;
                }
            }
        }
    }
}

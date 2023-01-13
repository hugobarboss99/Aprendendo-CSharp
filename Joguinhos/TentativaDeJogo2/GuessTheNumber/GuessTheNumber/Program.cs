using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 100
            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            // Initialize game variables
            int guess;
            int attempts = 0;
            bool correct = false;

            // Game loop
            while (!correct)
            {
                // Get player's guess
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());

                // Check if guess is correct
                if (guess == secretNumber)
                {
                    correct = true;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low. Try again.");
                }
                else
                {
                    Console.WriteLine("Too high. Try again.");
                }

                attempts++;
            }

            // Display success message
            Console.WriteLine("Congratulations! You guessed the number in " + attempts + " attempts.");
        }
    }
}

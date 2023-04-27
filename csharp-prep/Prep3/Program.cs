using System;

class Program
{
    static void Main(string[] args)
    {
        bool playGame = true;

        // Start game
        while (playGame)
        {
            // Generate a random number
            Random randGen = new Random();
            int magicNumber = randGen.Next(1, 101);

            // Variable to store user's guess
            int guess = -1;

            // Variable to keep count of 
            // of the user's total guess
            int totGuess = 0;

            while (guess != magicNumber)
            {
                // Ask the user for the magic number
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                // Increment the total guess
                totGuess += 1;

                // Condition to check the user's guess
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else {
                    Console.WriteLine("You guessed it!");
                    // Print total number of guess(es)
                    if (totGuess == 1)
                    {
                        Console.WriteLine($"It took you {totGuess} guess.");
                    }
                    else
                    {
                        Console.WriteLine($"It took you {totGuess} guesses.");
                    }
                }
            }

            // Ask the user if he wants to play again
            Console.Write("\nDo you want to play again (y/n)? ");
            string playAgain = Console.ReadLine().ToLower();
            Console.WriteLine();

            // Condition to determine if the user should play again
            if (playAgain != "y")
            {
                playGame = false;
            }
        }
        // Thank the user and exit the game.
        Console.WriteLine("Thanks for playing!");
    }
}
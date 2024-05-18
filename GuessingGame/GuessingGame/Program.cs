using System;

class GuessingGame
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            PlayGame();

            Console.WriteLine("Do you want to play again? (yes/no)");
            string response = Console.ReadLine().ToLower();

            if (response != "yes" && response != "y")
            {
                playAgain = false;
            }
        }
        Console.WriteLine("Thanks for playing!");
    }

    static void PlayGame()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int userGuess = 0;
        int numberOfTries = 0;

        Console.WriteLine("I'm thinking of a number between 1 and 100...");
        Console.WriteLine("Can you guess the number I'm thinking of?");
        while (userGuess != numberToGuess)
        {
            Console.Write("Enter your guess:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out userGuess))
            {
                numberOfTries++;
                if (userGuess < numberToGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("That number is too low!");
                    Console.ResetColor();
                    Console.Beep(250,500);
                }
                else if (userGuess > numberToGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That number is too high!");
                    Console.ResetColor();
                    Console.Beep(750,500);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"That is the correct number! Congratulations! You guessed the number in {numberOfTries} tries!");
                    Console.ResetColor();
                    Console.Beep(500,500);
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Invalid input. Please enter a valid number between 1 and 100.");
                Console.ResetColor();
            }
        }
    }
}

class Program
{
    static int guessCounter = 0; 

    static void Main(string[] args)
    {
        Game();
    }

    static void Game()
    {
        Random randomnum = new Random();
        int magicNumber = randomnum.Next(1, 101);

        int guess = -1;
        guessCounter = 0; 

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
                guessCounter++;
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
                guessCounter++;
            }
            else
            {
                guessCounter++;
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {guessCounter} guesses to get it!");

                Console.Write("Want to play again? (Y/N): ");
                string restart = Console.ReadLine();

                if (restart.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    Game();
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
            }
        }
    }
}

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool playAgain = true;

            while (playAgain)
            {
                Random random = new Random();
                int correctNum = random.Next(1, 21);

                int guessAttempts = 5;
                int guessesMade = 0;

                Console.WriteLine("Welcome to my 'guess the number' game!");
                Console.WriteLine("The rules are simple. I'm going to think abou a number and you're going to guess what number it is.");
                Console.WriteLine($"You'll have {guessAttempts} attempts. Good luck! :) ");
                
                while (guessAttempts > 0)
                {
                    Console.WriteLine("Enter your guess here: ");
                    if (int.TryParse(Console.ReadLine(), out int guess))
                    {
                        guessesMade++;

                        if (guess == correctNum)
                        {
                            Console.WriteLine($"Congrats! You won! It took you {guessesMade} attempts to guess correctly.");
                            break;
                        }

                        else if (guess < correctNum)
                        {
                            Console.WriteLine("Too low. Try again!");
                        }

                        else if (guess > correctNum)
                        {
                            Console.WriteLine("Too high. Try again!");
                        }

                        guessAttempts--;
                        Console.WriteLine($"You have {guessAttempts} attempts left");

                    }

                    if (guessAttempts == 0)
                    {
                        Console.WriteLine($"GAME OVER! The correct number was {correctNum}.");
                        break; 
                    }
                }
                playAgain = PlayAgainMethod();
            }
        }

        static bool PlayAgainMethod()
        {
            Console.WriteLine("Want to try again? Please enter YES or NO");
            string input = Console.ReadLine().ToUpper();

            if (input == "NO")
            {
                Console.WriteLine("Okay then! Thanks for playing!");
            }

            else if (input != "YES" && input != "NO")
            {
                Console.WriteLine("Please enter YES or NO");
                return PlayAgainMethod();
            }
            return input == "YES"; 
        }
    }
}
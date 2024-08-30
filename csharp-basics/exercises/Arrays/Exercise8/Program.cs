using System;



namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] randomWords = { "raindance", "sidewalk", "sunflower", "platypus", "arrays" };
            Random rand = new Random();
            bool playAgain = true;

            while (playAgain)
            {
                string wordToGuess = randomWords[rand.Next(randomWords.Length)];
                char[] guessedLetters = new char[wordToGuess.Length];
                Array.Fill(guessedLetters, '_');
                char[] missedLetters = new char[5];
                int missedCount = 0;
                int maxTries = 5;
                int triesLeft = maxTries;

                while (triesLeft > 0 && !IsWordGuessed(wordToGuess, guessedLetters))
                {
                    DisplayWord(guessedLetters);
                    DisplayMisses(missedLetters, missedCount);
                    Console.WriteLine($"Tries left: {triesLeft}");
                    Console.Write("Guess a letter: ");

                    char guess = Char.ToLower(Console.ReadLine()[0]);

                    if (IsAlreadyGuessed(guess, guessedLetters, missedLetters, missedCount))
                    {
                        Console.WriteLine("You already guessed that letter. Try a different one!");
                        continue;
                    }

                    if (wordToGuess.Contains(guess))
                    {
                        UpdateGuessedLetters(wordToGuess, guessedLetters, guess);
                    }
                    else
                    {
                        missedLetters[missedCount++] = guess;
                        triesLeft--;
                    }

                    Console.Clear();
                }

                DisplayWord(guessedLetters);
                DisplayMisses(missedLetters, missedCount);

                if (IsWordGuessed(wordToGuess, guessedLetters))
                {
                    Console.WriteLine("You've successfully guessed the word!");
                }
                else
                {
                    Console.WriteLine($"You lost! The word was: {wordToGuess}");
                }

                Console.Write("Would you like to play again (yes/no)? ");
                string playOrNo = Console.ReadLine().ToLower();
                playAgain = playOrNo == "yes" || playOrNo == "again";
                Console.Clear();
            }
        }

        private static void DisplayWord(char[] guessedLetters)
        {
            Console.Write("Word: ");
            foreach (char letter in guessedLetters)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();
        }

        private static void DisplayMisses(char[] missedLetters, int missedCount)
        {
            Console.Write("Misses: ");
            for (int i = 0; i < missedCount; i++)
            {
                Console.Write(missedLetters[i] + " ");
            }
            Console.WriteLine();
        }

        private static bool IsWordGuessed(string word, char[] guessedLetters)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (guessedLetters[i] == '_')
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsAlreadyGuessed(char guess, char[] guessedLetters, char[] missedLetters, int missedCount)
        {
            for (int i = 0; i < guessedLetters.Length; i++)
            {
                if (guessedLetters[i] == guess)
                {
                    return true;
                }
            }

            for (int i = 0; i < missedCount; i++)
            {
                if (missedLetters[i] == guess)
                {
                    return true;
                }
            }

            return false;
        }

        private static void UpdateGuessedLetters(string word, char[] guessedLetters, char guess)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == guess)
                {
                    guessedLetters[i] = guess;
                }
            }
        }
    }
}


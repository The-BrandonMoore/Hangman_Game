using Hangman_Game.Models;
namespace Hangman_Game
{
    internal class Program
    {
        static HangmanWords hangmanWords = new HangmanWords();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("Bad news. You and a friend were captured by a crazy person.");
            Console.WriteLine("He has chosen to allow you the chance to save both of your lives.");
            Console.WriteLine("In order to survive, you must guess the correct word. You will have 5 chances.");
            Console.WriteLine("Good luck.");

            string continuePlaying = "y";
            while (continuePlaying == "y")
            {

                string secretWord = hangmanWords.GetRandomWord();
                string hiddenWord = hangmanWords.GetHiddenWord(secretWord);
                int incorrectGuesses = 0;
                bool wordGuessed = false;
                List<string> lettersGuessed = new();

                while (incorrectGuesses != 6 && !wordGuessed) 
                {

                    Console.WriteLine(getHangmanImage(incorrectGuesses));
                    Console.WriteLine($"hint: {secretWord}");
                    Console.WriteLine(hiddenWord);
                    Console.Write("Guess a letter:  ");
                    string letterGuess = Console.ReadLine().ToLower();
                    lettersGuessed.Add(letterGuess);
                    Console.WriteLine($"You guessed {letterGuess}");

                
                }





                //Console.WriteLine(getHangmanImage(0));





                continuePlaying = ContinePlayingMethod();

            }
            Console.WriteLine("Bye");
        }

        private static string ContinePlayingMethod()
        {
            string keepPlaying = "";
            bool isValid = false;
            while (!isValid)
            {
                Console.Write("Would you like to play again? (y/n)  ");
                keepPlaying = Console.ReadLine().ToLower();
                if (keepPlaying == "")
                {
                    Console.WriteLine("Entry Required.");
                }
                else if (keepPlaying != "y" && keepPlaying != "n")
                {
                    Console.WriteLine("Please enter a valid answer (y/n) ");
                }
                else
                {
                    break;
                }
            }

            return keepPlaying;
        }

        static string getHangmanImage(int guessNumber)
        {
            string[] hangmanImages = { EmptyGallows(), GallowsPlusHead(), GallowsTorso(), GallowsLeftArm(), GallowsRightArm(), GallowsLeftLeg(), HangedHangMan() };

            return hangmanImages[guessNumber];
        }
        public static string HangedHangMan()
        {
            string hangman = @"
                _______
                |     |
                |     O
                |    /|\
                |    / \
                |
                ---------";
            //Console.WriteLine(hangman);
            return hangman;
        }
        public static string EmptyGallows()
        {
            string gallows = @"
                _______
                |     |
                |     
                |    
                |    
                |
                ---------";
            //Console.WriteLine(gallows);
            return gallows;
        }
        public static string GallowsPlusHead()
        {
            string gallows = @"
                _______
                |     |
                |     O
                |    
                |    
                |
                ---------";
            //Console.WriteLine(gallows);
            return gallows;
        }
        public static string GallowsTorso()
        {
            string gallows = @"
                _______
                |     |
                |     O
                |     | 
                |    
                |
                ---------";
            //Console.WriteLine(gallows);
            return gallows;
        }
        public static string GallowsLeftArm()
        {
            string gallows = @"
                _______
                |     |
                |     O
                |    /| 
                |    
                |
                ---------";
            //Console.WriteLine(gallows);
            return gallows;
        }
        public static string GallowsRightArm()
        {
            string gallows = @"
                _______
                |     |
                |     O
                |    /|\ 
                |    
                |
                ---------";
            //Console.WriteLine(gallows);
            return gallows;
        }
        public static string GallowsLeftLeg()
        {
            string gallows = @"
                _______
                |     |
                |     O
                |    /|\ 
                |    / 
                |
                ---------";
            //Console.WriteLine(gallows);
            return gallows;
        }




    }
}

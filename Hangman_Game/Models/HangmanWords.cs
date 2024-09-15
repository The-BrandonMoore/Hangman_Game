using System.Text;

namespace Hangman_Game.Models
{
    public class HangmanWords
    {
        public void Words() { }
        public static List<string> words = new List<string>
        {
            "horizon",
            "galaxy",
            "crystal",
            "mountain",
            "adventure",
            "journey",
            "diamond",
            "phantom",
            "freedom",
            "mystery",
            "explore",
            "vision",
            "puzzle",
            "treasure",
            "fortune",
            "paradox",
            "gravity",
            "vortex",
            "serenity",
            "whisper"
        };

        public static Random random = new Random();

        public string GetHiddenWord(string secretWord)
        {
            //returns a string that represents the "hidden" version of the word.turns the secret word to all dashes for initial user display

            StringBuilder hiddenWord = new StringBuilder();
            for (int i = 0; i < secretWord.Length; i++)
            {
                hiddenWord.Append('_');
                hiddenWord.Append(' ');

            }

            return hiddenWord.ToString().Trim();
        }
        public string GetRandomWord()
        {
            //gets the string word the user is trying to guess

            int randomNumber = random.Next(0, words.Count);

            string randomWord = words[randomNumber];
            return randomWord;
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Game
    {
        private Word word;
        private String wordPicked;
        private LinkedList<String> guesses;


        public Game()
        {
            this.word = new Word();
            guesses = new LinkedList<string>();
        }
        public Game(Word word)
        {
            this.word = word;
            guesses = new LinkedList<string>();
        }
        
        public void setPickedWord(String word)
        {
            this.wordPicked = word;
        }
        
        public void updateDisplay()
        {
            for(int i = 0; i < wordPicked.Length; i++)
            {
                if (guesses.Contains(wordPicked.ElementAt(i).ToString()))
                {

                }
            }

        }

        public bool addGuess(String guess)
        {
            guess.Trim().ToLower();
            if(guess.Equals(null) || guess.Equals(""))
            {
                Console.WriteLine("\ninvalid guess");
                return false;
            }
            if (guesses.Contains(guess))
            {
                Console.WriteLine("\nAlready guessed that!");
                return false;
            }
            guesses.AddLast(guess);
            return true;
        }

        public String pickWord()
        {
            this.wordPicked = word.pickWord();
            return wordPicked;
        }

        public int wordPickedLength()
        {
            return wordPicked.Length;
        }

        public int numWords()
        {
            return word.count();
        }

        //this is for testing purposes
        static void main()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HangMan
{
    class Game
    {
        private String[] man = {"\n", "   O", "  \\O\n", "  \\O/\n", "  \\O/\n   |", "  \\O/\n   |\n  /", "  \\O/\n   |\n  / \\" };
        private int chances;
        private Word word;
        private String wordPicked;
        private int wrong;
        private LinkedList<String> guesses;

        public Game()
        {
            this.wrong = 0;
            this.word = new Word();
            this.guesses = new LinkedList<string>();
        }
        public Game(Word word)
        {
            this.chances = 0;
            this.word = word;
            this.guesses = new LinkedList<string>();
        }
        
        public void setPickedWord(String word)
        {
            this.wordPicked = word;
        }
        
        /**
         * 1. Display the HangMan!
         * 2. Display the _ and letters
         * 3. Display the Used letters (previous guesses).
         */ 
        public void updateDisplay()
        {
            Console.WriteLine(man[wrong]+"\n");
            for(int i = 0; i < wordPicked.Length; i++)
            {
                if (guesses.Contains(wordPicked.ElementAt(i).ToString()))
                {
                    Console.Write(wordPicked.ElementAt(i)+" ");
                }else
                {
                    Console.Write("_ ");
                }
            }
            //display Used letter(previous guesses).
            Console.Write("\nGuesses: ");
            foreach(String guess in guesses)
            {
                Console.Write(guess.ToString());
            }
        }



        /**
         * checks to see if the game has ended. 
         * if chances is 6 or above return true(end).
         * if there is a lettter in wordPicked that is not in guessses return false(dont end).
         */
        public bool end()
        {
            if(chances > 6)
            {
                return true;
            }
            for(int i = 0; i < wordPicked.Length; i++)
            {
                if (!guesses.Contains(wordPicked.ElementAt(i).ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        /*
         * add a guess into the guesses LL.
         * if guess is null or already in the list, increment wrong and return false.
         * if guess is not in the wordPicked, increment wrong and return false.
         * if valid add guess to end of guesses LL and return true.
         */ 
        public bool addGuess(String guess)
        {
            guess.Trim().ToLower();
            if(guess.Equals(null) || guess.Equals(""))
            {
                Console.WriteLine("\ninvalid guess");
                wrongPlus();
                return false;
            }
            if (guesses.Contains(guess))
            {
                Console.WriteLine("\nAlready guessed that!");
                wrongPlus();
                return false;
            }
            if (!wordPicked.Contains(guess))
            {
                Console.WriteLine("\nWrong!");
                guesses.AddLast(guess);
                wrongPlus();
                return false;
            }
            guesses.AddLast(guess);
            return true;
        }

        /*
         * increment your wrong counter and end game if you go above 6.
         */ 
        private void wrongPlus()
        {
            if (wrong == 6)
            {
                Console.Clear();
                Console.WriteLine("You have Lost!");
                Thread.Sleep(3000);
                Environment.Exit(0);
            } else
            {
                wrong++;
            }
        }

        /**
         * Word object has a pickWord() function that randomly picks a word from the linked list.
         * then stores the random word into wordPicked string.
         * return the random word picked.
         */ 
        public String pickWord()
        {
            this.wordPicked = word.pickWord();
            return wordPicked;
        }

        /*
         * return the length of the word picked.
         */ 
        public int wordPickedLength()
        {
            return wordPicked.Length;
        }

        /*
         * retur nthe number of words in the word LL.
         */ 
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

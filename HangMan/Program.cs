using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //game start - get word(s), display _'s.
                Word wordList = new Word();
                Game game;
                Console.Write("Hangman! \n\n");
                while (true)
                {
                    Console.Write("Player 1, please enter your word, enter nothing when done.\n");
                    String wordEntered = Console.ReadLine().Trim().ToLower().Replace(" ", String.Empty);
                    Console.WriteLine("");
                    if(wordEntered == "" && wordList.count() > 0)
                    {
                        break;
                    }
                    wordList.addWord(wordEntered);
                }
                game = new Game(wordList);
                game.pickWord();
                for(int i = 0; i < game.wordPickedLength(); i++)
                {
                    Console.Write("_ ");
                }
                Console.WriteLine("\n\n");
                Console.Clear();
                //get guess, display right or wrong, redraw display
                while (true)
                {
                    while (true)
                    {
                        Console.Write("\nPlayer 2, Enter Guess: ");
                        if (game.addGuess(Console.ReadKey().KeyChar.ToString().ToLower()))
                        {
                            break;
                        }
                        Console.Clear();
                        Console.WriteLine("Wrong!");
                        game.updateDisplay();
                    }
                    game.updateDisplay();
                    if (game.end())
                    {
                        Console.WriteLine("Congratulations you won!");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;
                    }
                }
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Word
    {
        private LinkedList<String> wordList;

        public Word()
        {
            wordList = new LinkedList<string>();
        }

        public void addWord()
        {
            Console.Write("P1 add Word: ");
            String wordToAdd = Console.ReadLine();
            wordToAdd.ToLower().Trim().Replace(" ", String.Empty);
            wordList.AddLast(wordToAdd);
        }

        public String pickWord()
        {
            if(wordList.Count <= 0)
            {
                Console.Write("No more words. Please add more.");
            }
            Random rand = new Random();
            String wordPicked = wordList.ElementAtOrDefault(rand.Next(0, wordList.Count()));
            wordList.Remove(wordPicked);
            return wordPicked;
        }







        //testing
        static void TestWord(String[] args)
        {
            Word word = new Word();
            Console.Write(word.pickWord());
            
        }
    }
}

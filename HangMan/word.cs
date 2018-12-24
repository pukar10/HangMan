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

        public void addWord(String word)
        {
            if(word == null || word == "")
            {
                Console.Write("enter a real word.");
            }else
            {
                wordList.AddLast(word);
            }
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

        public int count()
        {
            return wordList.Count();
        }


        //testing
        static void Main(String[] args)
        {
            Word word = new Word();
            word.addWord("complete");
            word.addWord("start");
            Console.Write(word.pickWord());
            Console.ReadKey();
            
        }
    }
}

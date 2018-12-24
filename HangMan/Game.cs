using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Game
    {
        private Boolean lose;
        Word word;


        public Game()
        {
            this.lose = false;
            word = new Word();
        }

        public static void fillList(String[] words, LinkedList<String> list)
        {
            foreach(String word in words){
                list.AddLast(word);
            }
        }

        public void display()
        {
            
        }

        //this is for testing purposes
        static void main()
        {


            String[] words = { "start", "here", "great", "game", "amazing", "insane", "stumped", "zebra", "racoon", "slippery", "zonks", "temporary", "attorny", "confused", "startled", "instatiable" };
            LinkedList<String> wordList = new LinkedList<string>();
            fillList(words, wordList);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Game game = new Game();
                Console.Write("Hello! lets play some hangman.\n");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}

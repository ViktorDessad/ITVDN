using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Classes
{
    class WordIdentify
    {
        private string word = null;

        public void SetWord(string value)
        {
            if (value == "fool")
            {
                word = value;
                Console.WriteLine("This is a bad word {0}", word);
            }
            else
            {
                word = value;
                Console.WriteLine("This is a good word {0}", word);
            }
        }

        public string GetWord()
        {
            return word;
        }
    }

    public class Program
    {
        public static void Main()
        {
            WordIdentify word = new WordIdentify();
            Console.Write("Enter a word: ");
            word.SetWord(Console.ReadLine());
            string str = word.GetWord();
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}

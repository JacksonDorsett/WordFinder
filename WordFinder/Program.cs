using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMaker
{
    using DictionaryLib;
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new FileDictionary(@"C:\Users\dorse\source\repos\WordStats\WordStats\bin\Debug\Dictionary.txt");
            //string[] words = { "hello", "he", "hell", "hole" };
            //foreach (string s in words)
            //{
            //    dict.Add(s);
            //}
            WordFinder wf = new WordFinder(dict);
            var l = wf.GetWords(Console.ReadLine());
            l = GetList(3, l);
            l = l.OrderBy(x => x.Length).ToList();
            
                         
            foreach(string s in l)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }

        static List<string> GetList(int minLength, List<string> l)
        {
            l.Sort();
            var ret = new List<String>();
            foreach(string s in l)
            {
                if (s.Length >= minLength)
                {
                    ret.Add(s);
                }
            }
            return ret;
        }
    }
}

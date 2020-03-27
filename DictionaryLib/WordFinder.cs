using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLib
{
    public class WordFinder
    {
        private WordFinderDictionary dictionary;
        

        public WordFinder(Dictionary dictionary)
        {
            this.dictionary = new WordFinderDictionary(dictionary);
        }

        
        public List<string> GetWords(string s)
        {
            Dictionary<string, bool> words = new Dictionary<string, bool>();
            permute(s, 0, s.Length - 1,words);
            List<string> ret = new List<string>();
            foreach (KeyValuePair<string,bool> pair in words)
            {
                ret.Add(pair.Key);
            }
            return ret;
        }
        
        private string Swap(string s, int l, int r)
        {
            char[] arr = s.ToCharArray();
            char temp = arr[l];
            arr[l] = arr[r];
            arr[r] = temp;
            return new string(arr);
        }
        private void permute(string a, int l, int r, Dictionary<string,bool> words)
        {
            // Base case  
            if (l == r)
                dictionary.Add(words, a);
            else
            {
                // Permutations made  
                for (int i = l; i <= r; i++)
                {

                    // Swapping done  
                    char temp = a[l];
                    
                    a = Swap(a, l, i);

                    // Recursion called  
                    permute(a, l + 1, r, words);

                    //backtrack  
                    a = Swap(a, l, i);
                }
            }
        }

    }
}

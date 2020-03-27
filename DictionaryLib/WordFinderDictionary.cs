using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLib
{
    
    internal class WordFinderDictionary : ConstantDictionary
    {
        internal WordFinderDictionary(Dictionary dictionary)
        {
            this.mHead = dictionary.mHead;
            this.mSize = dictionary.Count;
        }

        public void Add(Dictionary<string, bool> words, string word)
        {
            var curNode = this.mHead;
            for (int i = 0; i < word.Length; ++i)
            {
                if (!curNode.HasChild(word[i]))
                {
                    break;
                }
                curNode = curNode.GetChild(word[i]);
                if (curNode.IsWord && !words.ContainsKey(word.Substring(0, i+1)))
                {
                    words[word.Substring(0, i + 1)] = true;
                }
            }
        }
        //internal void LookupWords()
    }
}

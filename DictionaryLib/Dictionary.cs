using System;
using System.Collections.Generic;
namespace DictionaryLib
{
    abstract public class Dictionary
    {
        public Dictionary()
        {
            mHead = new DictionaryNode();
            mSize = 0;
        }
        internal DictionaryNode mHead;
        protected int mSize;
        public int Count{ get => mSize; }
        protected void Add(string s)
        {
            s = FormatString(s);
            var curNode = mHead;
            for(int i = 0; i < s.Length; ++i)
            {
                
                curNode.AddChild(s[i]);
                curNode = curNode.GetChild(s[i]);
            }
            if (!curNode.IsWord)
            {
                mSize++;
            }
            curNode.IsWord = true;
            
        }
        public bool LookUp(string word)
        {
            word = FormatString(word);
            var curNode = this.mHead;
            for (int i = 0; i < word.Length; i++)
            {
                if (!curNode.HasChild(word[i]))
                {
                    return false;
                }
                curNode = curNode.GetChild(word[i]);
            }
            return curNode.IsWord;
        }

        private string FormatString(string word)
        {
            return word.ToLower();
        }
    }
}

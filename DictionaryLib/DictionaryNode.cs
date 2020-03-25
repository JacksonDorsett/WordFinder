using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryLib
{
    internal class DictionaryNode
    {
        protected Dictionary<char, DictionaryNode> children;
        protected bool isWord;
        internal DictionaryNode()
        {
            this.children = new Dictionary<char, DictionaryNode>();
            this.isWord = false;
        }
        internal bool IsWord
        {
            get
            {
                return this.isWord;
            }
        }


        internal bool AddChild(char c)
        {
            return false;
        }
        internal DictionaryNode GetChild(char c)
        {
            return null;
        }
        internal bool HasChild(char c)
        {
            return false;
        }
        
    }
}

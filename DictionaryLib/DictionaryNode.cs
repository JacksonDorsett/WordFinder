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
            set
            {
                this.isWord = value;
            }
        }


        internal bool AddChild(char c)
        {
            if(HasChild(c))
            {
                return false;
            }
            else
            {
                children[c] = new DictionaryNode();
                return true;
            }
        }
        internal DictionaryNode GetChild(char c)
        {
            if(HasChild(c))
            {
                return children[c];
            }
            return null;
        }
        internal bool HasChild(char c)
        {
            return this.children.ContainsKey(c);
        }
        
    }
}


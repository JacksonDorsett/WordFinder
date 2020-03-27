using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryLib
{
    public class ConstantDictionary : Dictionary
    {
        public new bool LookUp(string word)
        {
            return base.LookUp(word);
        }
    }
}

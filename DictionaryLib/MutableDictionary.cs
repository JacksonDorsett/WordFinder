﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryLib
{
    public class MutableDictionary : Dictionary
    {
        public new void Add(string word)
        {
            base.Add(word);
        }
        public new bool LookUp(string word)
        {
            return base.LookUp(word);
        }

    }
}

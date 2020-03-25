using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryLib
{
    public class MutableDictionary : Dictionary
    {
        protected override bool Add(string s)
        {
            throw new NotImplementedException();
        }
    }
}

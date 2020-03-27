using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryLib
{
    using System.IO;
    public class FileDictionary : ConstantDictionary
    {
        
        public FileDictionary(string filePath)
        {
            try
            {
                if(File.Exists(filePath))
                {
                    foreach (string s in File.ReadAllText(filePath).Split('\n', ' '))
                    {
                        Add(s.Replace("\r", ""));
                    }
                }
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

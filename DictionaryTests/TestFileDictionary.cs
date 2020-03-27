
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTests
{
    using System.IO;
    using NUnit.Framework;
    using DictionaryLib;
    [TestFixture]
    public class TestFileDictionary
    {
        private string path = @"C:\";
        [SetUp]
        public void CreateDictionaryFiles()
        {
            string[] words = { "hello", "hi", "heat", "apple" };
            StreamWriter sw = new StreamWriter("Test.txt");
            foreach(string word in words)
            {
                sw.WriteLine(word);
            }
        }
        [Test]
        public void TestNormalInput()
        {
            FileDictionary fd = new FileDictionary(path + "TestDictionary.txt");
        }

        [TearDown]
        public void CleanupTestFiles()
        {
            try
            {
                string dir = System.IO.Path.GetDirectoryName(
      System.Reflection.Assembly.GetExecutingAssembly().Location);
            }
            catch
            {
                
            }
            
        }
    }
}

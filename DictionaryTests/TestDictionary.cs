using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTests
{
    using NUnit.Framework;
    using DictionaryLib;
    [TestFixture]
    class TestDictionaryClass
    {
        class TestDict : Dictionary
        {
            public new void Add(string s)
            {
                base.Add(s);
            }
            public new bool LookUp(string s)
            {
                return base.LookUp(s);
            }
        }

        [Test]
        public void TestAdd()
        {
            TestDict t = new TestDict();
            t.Add("hello");
            t.Add("he");
            t.Add("He");
            Assert.AreEqual(2, t.Count);
        }

        [Test]
        public void TestLookup()
        {
            TestDict t = new TestDict();
            t.Add("hello");
            t.Add("he");
            t.Add("He");
            Assert.IsFalse(t.LookUp("h"));
            Assert.IsTrue(t.LookUp("HE"));
            Assert.IsTrue(t.LookUp("he"));
            Assert.IsFalse(t.LookUp("hel"));
            Assert.IsFalse(t.LookUp("hell"));
            Assert.IsTrue(t.LookUp("Hello"));

        }

    }
}

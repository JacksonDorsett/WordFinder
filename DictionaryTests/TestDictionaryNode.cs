// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using DictionaryLib;
namespace DictionaryTests
{
    [TestFixture]
    public class TestDictionaryNode
    {
        [Test]
        public void TestHasChildNoChildren()
        {
            var t = new DictionaryNode();
            for (char i = 'a'; i <= 'z';++i)
            {
                Assert.IsFalse(t.HasChild(i));
            }
        }

        

        [Test]
        public void TestAddChild()
        {
            var t = new DictionaryNode();
            Assert.IsTrue(t.AddChild('a'));
            Assert.IsTrue(t.HasChild('a')); //dependent on HasChild Tests
        }
        [Test]
        public void TestHasChildWithChildren()
        {
            var t = new DictionaryNode();
            for (char i = 'a'; i <= 'z'; ++i)
            {
                t.AddChild(i);
                Assert.IsTrue(t.HasChild(i));
            }
            Assert.IsFalse(t.AddChild('a'));
        }
        [Test]
        public void TestGetChild()
        {
            var t = new DictionaryNode();
            //test null return
            Assert.IsNull(t.GetChild('a'));

            Assert.IsTrue(t.AddChild('a'));
            Assert.IsNotNull(t.GetChild('a'));

        }
    }
}

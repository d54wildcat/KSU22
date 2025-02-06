/* DictionaryTests.cs
 * Author: Rod Howell
 */
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Ksu.Cis300.NameLookup.Tests
{
    /// <summary>
    /// Unit tests for the Dictionary class.
    /// </summary>
    [TestFixture]
    public class DictionaryTests
    {
        /// <summary>
        /// Gets a dictionary containing five keys and values.
        /// </summary>
        private Dictionary<int, string> LoadDictionary()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(10, "Ten");
            d.Add(5, "Five");
            d.Add(15, "Fifteen");
            d.Add(7, "Seven");
            d.Add(20, "Twenty");
            return d;
        }
        /// <summary>
        /// Tests that a correct exception is thrown when a null key is added.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestAAddNullKey()
        {
            Dictionary<string, float> d = new Dictionary<string, float>();
            Exception ex = null;
            try
            {
                d.Add(null, 0);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.That(ex, Is.Not.Null.And.TypeOf(typeof(ArgumentNullException)));
        }

        /// <summary>
        /// Tests that a correct exception is thrown when a null key is looked up.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestALookUpNullKey()
        {
            Dictionary<string, double> d = new Dictionary<string, double>();
            Exception ex = null;
            double x;
            try
            {
                d.TryGetValue(null, out x);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.That(ex, Is.Not.Null.And.TypeOf(typeof(ArgumentNullException)));
        }

        /// <summary>
        /// Tests a lookup on an empty dictionary. TryGetValue should return false
        /// and set its out parameter to null.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestBLookUpEmpty()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            string s;
            Assert.Multiple(() =>
            {
                Assert.That(d.TryGetValue(7, out s), Is.False);
                Assert.That(s, Is.Null);
            });
        }

        /// <summary>
        /// Adds one key and value, then looks it up.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestCAddOneLookItUp()
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("one", 1);
            int i;
            Assert.Multiple(() =>
            {
                Assert.That(d.TryGetValue("one", out i), Is.True);
                Assert.That(i, Is.EqualTo(1));
            });
        }

        /// <summary>
        /// Tests that the proper exception is thrown if a duplicate key is added.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDAddDuplicate()
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("two", 2);
            d.Add("one", 1);
            Exception ex = null;
            try
            {
                d.Add("two", 2);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.That(ex, Is.Not.Null.And.TypeOf(typeof(ArgumentException)));
        }

        /// <summary>
        /// Adds five keys and values, then looks up the one that should be
        /// first in the list.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDLookUpFirst()
        {
            Dictionary<int, string> d = LoadDictionary();
            string s;
            Assert.Multiple(() =>
            {
                Assert.That(d.TryGetValue(5, out s), Is.True);
                Assert.That(s, Is.EqualTo("Five"));
            });
        }

        /// <summary>
        /// Adds five keys and values, then looks up the one that should be last
        /// in the list.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDLookUpLast()
        {
            Dictionary<int, string> d = LoadDictionary();
            string s;
            Assert.Multiple(() =>
            {
                Assert.That(d.TryGetValue(20, out s), Is.True);
                Assert.That(s, Is.EqualTo("Twenty"));
            });
        }

        /// <summary>
        /// Adds five keys and values, then looks up a key smaller than any in the dictionary.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDLookUpSmaller()
        {
            Dictionary<int, string> d = LoadDictionary();
            string s;
            Assert.Multiple(() =>
            {
                Assert.That(d.TryGetValue(3, out s), Is.False);
                Assert.That(s, Is.Null);
            });
        }

        /// <summary>
        /// Adds five keys and values, then looks up a nonexistent key belonging in the
        /// middle of the list.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDLookUpMiddle()
        {
            Dictionary<int, string> d = LoadDictionary();
            string s;
            Assert.Multiple(() =>
            {
                Assert.That(d.TryGetValue(13, out s), Is.False);
                Assert.That(s, Is.Null);
            });
        }

        /// <summary>
        /// Adds five keys and values, then looks up a key larger than any in the dictionary.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDLookUpGreater()
        {
            Dictionary<int, string> d = LoadDictionary();
            string s;
            Assert.Multiple(() =>
            {
                Assert.That(d.TryGetValue(25, out s), Is.False);
                Assert.That(s, Is.Null);
            });
        }

        /// <summary>
        /// Adds five keys and values, then looks up all of them.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestELookUpAll()
        {
            Dictionary<int, string> d = LoadDictionary();
            Assert.Multiple(() =>
            {
                Assert.That(d.TryGetValue(5, out string s), Is.True);
                Assert.That(s, Is.EqualTo("Five"));
                Assert.That(d.TryGetValue(7, out s), Is.True);
                Assert.That(s, Is.EqualTo("Seven"));
                Assert.That(d.TryGetValue(10, out s), Is.True);
                Assert.That(s, Is.EqualTo("Ten"));
                Assert.That(d.TryGetValue(15, out s), Is.True);
                Assert.That(s, Is.EqualTo("Fifteen"));
                Assert.That(d.TryGetValue(20, out s), Is.True);
                Assert.That(s, Is.EqualTo("Twenty"));
            });
        }
    }
}
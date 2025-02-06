/* StackTest.cs
 * Author: Rod Howell
 */
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ksu.Cis300.LinkedListLibrary.Tests
{
    /// <summary>
    /// A unit tests class for the class library Ksu.Cis300.LinkedListLibrary.
    /// </summary>
    [TestFixture]
    public class StackTest
    {
        /// <summary>
        /// Tests that Count is defined as a property.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestACountPropertyExists()
        {
            Type type = new Stack<int>().GetType();
            Assert.That(type.GetProperty("Count") != null);
        }

        /// <summary>
        /// Tests that a Peek on an empty stack throws an InvalidOperationException.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestAEmptyPeek()
        {
            Stack<int> s = new Stack<int>();
            Exception ex = null;
            try
            {
                s.Peek();
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.That(ex, Is.Not.Null.And.TypeOf(typeof(InvalidOperationException)));
        }

        /// <summary>
        /// Tests that a Pop on an empty stack throws an InvalidOperationException.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestBEmptyPop()
        {
            Stack<string> s = new Stack<string>();
            Exception ex = null;
            try
            {
                s.Pop();
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.That(ex, Is.Not.Null.And.TypeOf(typeof(InvalidOperationException)));
        }

        /// <summary>
        /// Tests whether the count is correctly updated after pushing twice.
        /// The count should be 2.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestCCountAfterPush()
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            Assert.That(s.Count, Is.EqualTo(2));
        }

        /// <summary>
        /// Tests whether the count is correctly updated after pushing three times
        /// and popping once.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDCountAfterPop()
        {
            Stack<char> s = new Stack<char>();
            s.Push('a');
            s.Push('b');
            s.Push('c');
            s.Pop();
            Assert.That(s.Count, Is.EqualTo(2));
        }

        /// <summary>
        /// Tests whether Peek returns the correct value after three items are pushed onto
        /// the stack.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDSimplePeek()
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.That(s.Peek(), Is.EqualTo(3));
        }

        /// <summary>
        /// Tests whether Pop returns the correct value after three items are pushed onto
        /// the stack.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDSimplePop()
        {
            Stack<char> s = new Stack<char>();
            s.Push('a');
            s.Push('b');
            s.Push('c');
            Assert.That(s.Pop(), Is.EqualTo('c'));
        }

        /// <summary>
        /// Tests the results of a sequence of 6 Pushes followed by 6 Pops.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestEMultiplePop()
        {
            Stack<char> s = new Stack<char>();
            for (char c = 'a'; c < 'g'; c++)
            {
                s.Push(c);
            }
            StringBuilder sb = new StringBuilder();
            while (s.Count > 0)
            {
                sb.Append(s.Pop());
            }
            Assert.That(sb.ToString(), Is.EqualTo("fedcba"));
        }
    }
}
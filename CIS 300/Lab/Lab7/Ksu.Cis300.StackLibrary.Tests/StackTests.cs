/* StackTests.cs
 * Author: Rod Howell
 * Modified by: Dacey Wieland
 */
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Ksu.Cis300.StackLibrary.Tests
{
    /// <summary>
    /// A unit tests class for the class library Ksu.Cis300.StackLibrary.
    /// </summary>
    [TestFixture]
    public class StackTests
    {
        /// <summary>
        /// Tests that the Count property is indeed a property
        /// </summary>
        [Test, Timeout(1000)]
        public void TestCountPropertyExists()
        {
            Type type = new Stack<int>().GetType();
            Assert.That(type.GetProperty("Count") != null);
        }

        /// <summary>
        /// Tests that the Capacity property is indeed a property.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestCapacityPropertyExists()
        {
            Type type = new Stack<int>().GetType();
            Assert.That(type.GetProperty("Capacity") != null);
        }

        /// <summary>
        /// Tests whether the array size is initially 5.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestAInitialCapacity()
        {
            Stack<double> s = new Stack<double>();
            Assert.That(s.Capacity, Is.EqualTo(5));
        }
        /// <summary>
        /// Tests a Peek on an empty stack. The test will pass if an InvalidOperationException
        /// is thrown; otherwise, it will fail.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestAEmptyPeek()
        {
            Stack<string> s = new Stack<string>();
            Exception e = null;
            try
            {
                s.Peek();
            }
            catch (Exception ex)
            {
                e = ex;
            }
            Assert.That(e, Is.Not.Null.And.TypeOf(typeof(InvalidOperationException)));
        }

        /// <summary>
        /// Tests a Pop on an empty stack. The test will pass if an InvalidOperationException
        /// is thrown. Otherwise, it will fail.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestAEmptyPop()
        {
            Stack<string> s = new Stack<string>();
            Exception e = null;
            try
            {
                s.Pop();
            }
            catch (Exception ex)
            {
                e = ex;
            }
            Assert.That(e, Is.Not.Null.And.TypeOf(typeof(InvalidOperationException)));
        }

        /// <summary>
        /// Tests whether the count is correctly updated after pushing twice.
        /// The count should be 2.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestBCountAfterPush()
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
        public void TestCCountAfterPop()
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
        public void TestBSimplePeek()
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
        public void TestCSimplePop()
        {
            Stack<char> s = new Stack<char>();
            s.Push('a');
            s.Push('b');
            s.Push('c');
            Assert.That(s.Pop(), Is.EqualTo('c'));
        }

        /// <summary>
        /// Tests that upon clearing a stack, its Count is 0 and its Capacity is 5.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDClear()
        {
            Stack<string> s = new Stack<string>();
            s.Push("abc");
            s.Push("xyz");
            s.Clear();

            // Assert that the Count is 0 and the Capacity is 5
            Assert.That(new Tuple<int, int>(s.Count, s.Capacity), Is.EqualTo(new Tuple<int, int>(0, 5)));
        }

        /// <summary>
        /// Tests a sequence of three Pushes followed by three Pops.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestEMultiplePop()
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            int first = s.Pop();
            int second = s.Pop();
            int third = s.Pop();
            Assert.That(new Tuple<int, int, int>(first, second, third), Is.EqualTo(new Tuple<int, int, int>(3, 2, 1)));
        }

        /// <summary>
        /// Pushes k values onto s. The values are successive powers of 2.
        /// </summary>
        /// <param name="k">The number of values to push</param>
        /// <param name="s">The stack on which to push.</param>
        /// <returns>The sum of the elements pushed.</returns>
        private int PushMultiple(int k, Stack<int> s)
        {
            int val = 1;
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += val;
                s.Push(val);
                val *= 2;
            }
            return sum;
        }

        /// <summary>
        /// Tests whether the capacity is still 5 after 5 Pushes.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestFFiveCapacity()
        {
            Stack<int> s = new Stack<int>();
            PushMultiple(5, s);
            Assert.That(s.Capacity, Is.EqualTo(5));
        }

        /// <summary>
        /// Tests whether the capacity is 10 after 6 Pushes.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestGExpandCapacity()
        {
            Stack<int> s = new Stack<int>();
            PushMultiple(6, s);
            Assert.That(s.Capacity, Is.EqualTo(10));
        }

        /// <summary>
        /// Tests whether the capacity is 20 after 11 Pushes.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestHDoubleExpandCapacity()
        {
            Stack<int> s = new Stack<int>();
            PushMultiple(11, s);
            Assert.That(s.Capacity, Is.EqualTo(20));
        }

        /// <summary>
        /// Removes all elements from the stack, computing their sum.
        /// </summary>
        /// <param name="s">The stack.</param>
        /// <returns>The sum of the elements removed from the stack.</returns>
        private int SumAll(Stack<int> s)
        {
            int sum = 0;
            while (s.Count > 0)
            {
                sum += s.Pop();
            }
            return sum;
        }

        /// <summary>
        /// Tests whether a single expansion preserves all elements. The test is done
        /// by summing the elements as the are popped from the stack, and comparing
        /// with the sum of the elements pushed onto the stack.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestGExpand()
        {
            Stack<int> s = new Stack<int>();
            int inSum = PushMultiple(6, s);
            int outSum = SumAll(s);
            Assert.That(outSum, Is.EqualTo(inSum));
        }

        /// <summary>
        /// Tests whether two expansions preserve all elements.  The test is done by
        /// summing the elements as they are popped from the stack, and comparing
        /// with the sum of the elements pushed onto the stack.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestHDoubleExpand()
        {
            Stack<int> s = new Stack<int>();
            int inSum = PushMultiple(11, s);
            int outSum = SumAll(s);
            Assert.That(outSum, Is.EqualTo(inSum));
        }

        /// <summary>
        /// Tests that after expanding the array, a Clear resets the capacity to 5.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestIClearAfterExpand()
        {
            Stack<int> s = new Stack<int>();
            PushMultiple(6, s);
            s.Clear();
            Assert.That(s.Capacity, Is.EqualTo(5));
        }
    }
}
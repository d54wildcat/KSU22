/* QueueTests.cs
 * Author: Rod Howell
 */
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ksu.Cis300.QueueLibrary.Tests
{
    /// <summary>
    /// A unit tests class for the class library Ksu.Cis300.StackLibrary.
    /// </summary>
    [TestFixture]
    public class QueueTests
    {
        /// <summary>
        /// A string containing the lower-case letters.
        /// </summary>
        private string _alphabet = "abcdefghijklmnopqrstuvwxyz";

        /// <summary>
        /// Enqueues onto the given queue the n letters of the alphabet
        /// beginning with the one at position start.
        /// </summary>
        /// <param name="q">The queue in which to enqueue the characters.</param>
        /// <param name="start">The location in the alphabet at which to begin enqueueing.</param>
        /// <param name="n">The number of characters to enqueue.</param>
        private void EnqueueMultiple(Queue<char> q, int start, int n)
        {
            for (int i = 0; i < n; i++)
            {
                q.Enqueue(_alphabet[start + i]);
            }
        }

        /// <summary>
        /// Appends to the given StringBuilder the given number of chars dequeued
        /// from the given q.
        /// </summary>
        /// <param name="q">The queue from which to dequeue.</param>
        /// <param name="n">The number of elements to dequeue.</param>
        /// <param name="sb">The StringBuilder on which to append the dequeued elements.</param>
        private void DequeueMultiple(Queue<char> q, int n, StringBuilder sb)
        {
            for (int i = 0; i < n; i++)
            {
                sb.Append(q.Dequeue());
            }
        }

        /// <summary>
        /// Tests whether the array size is initially 5.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestAInitialCapacity()
        {
            Queue<int> q = new Queue<int>();
            Assert.That(q.Capacity, Is.EqualTo(5));
        }

        /// <summary>
        /// Tests a Peek on an empty queue. The test will pass if an InvalidOperationException
        /// is thrown; otherwise, it will fail.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestAEmptyPeek()
        {
            Queue<string> q = new Queue<string>();
            Exception e = null;
            try
            {
                q.Peek();
            }
            catch (Exception ex)
            {
                e = ex;
            }
            Assert.That(e, Is.Not.Null.And.TypeOf(typeof(InvalidOperationException)));
        }

        /// <summary>
        /// Tests a Dequeue on an empty queue. The test will pass if an InvalidOperationException
        /// is thrown. Otherwise, it will fail.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestAEmptyDequeue()
        {
            Queue<string> q = new Queue<string>();
            Exception e = null;
            try
            {
                q.Dequeue();
            }
            catch (Exception ex)
            {
                e = ex;
            }
            Assert.That(e, Is.Not.Null.And.TypeOf(typeof(InvalidOperationException)));
        }

        /// <summary>
        /// Tests whether the count is correctly updated after enqueueing twice.
        /// The count should be 2.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestBCountAfterEnqueue()
        {
            Queue<decimal> q = new Queue<decimal>();
            q.Enqueue(2.3m); // 2.3m is 2.3 as a decimal.
            q.Enqueue(-4);
            Assert.That(q.Count, Is.EqualTo(2));
        }

        /// <summary>
        /// Tests whether Peek returns the correct value after three items are enqueued.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestBSimplePeek()
        {
            Queue<char> q = new Queue<char>();
            q.Enqueue('a');
            q.Enqueue('b');
            q.Enqueue('c');
            Assert.That(q.Peek(), Is.EqualTo('a'));
        }

        /// <summary>
        /// Tests whether the count is correctly updated after enqueueing three times
        /// and dequeueing once.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestCCountAfterDequeue()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Dequeue();
            Assert.That(q.Count, Is.EqualTo(2));
        }

        /// <summary>
        /// Tests whether Dequeue returns the correct value after three items are enqueued.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestCSimpleDequeue()
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("ab");
            q.Enqueue("c");
            q.Enqueue("def");
            Assert.That(q.Dequeue(), Is.EqualTo("ab"));
        }

        /// <summary>
        /// Tests a sequence of 3 enqueues, followed by 3 dequeues.  The chars 'a',
        /// 'b', and 'c' are enqueued.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDMultipleDequeue()
        {
            Queue<char> q = new Queue<char>();
            EnqueueMultiple(q, 0, 3);
            StringBuilder sb = new StringBuilder();
            DequeueMultiple(q, 3, sb);
            Assert.That(sb.ToString(), Is.EqualTo(_alphabet.Substring(0, 3)));
        }

        /// <summary>
        /// Tests that after 5 Enqueues, the capacity is still 5.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestEFiveCapacity()
        {
            Queue<char> q = new Queue<char>();
            EnqueueMultiple(q, 0, 5);
            Assert.That(q.Capacity, Is.EqualTo(5));
        }

        /// <summary>
        /// Tests that after 4 Enqueues, a Dequeue, and 2 Enqueues, the capacity
        /// is still 5.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestFWrapCapacity()
        {
            Queue<char> q = new Queue<char>();
            EnqueueMultiple(q, 0, 4);
            q.Dequeue();
            EnqueueMultiple(q, 4, 2);
            Assert.That(q.Capacity, Is.EqualTo(5));
        }

        /// <summary>
        /// Tests the Count after an Enqueue causes a wrap-around.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestGCountAfterEnqueueWrap()
        {
            Queue<char> q = new Queue<char>();
            EnqueueMultiple(q, 0, 4);
            q.Dequeue();
            EnqueueMultiple(q, 4, 2);
            Assert.That(q.Count, Is.EqualTo(5));
        }

        /// <summary>
        /// Tests the Count after a Dequeue causes a wrap-around.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestHCountAfterDequeueWrap()
        {
            Queue<char> q = new Queue<char>();
            EnqueueMultiple(q, 0, 4);
            DequeueMultiple(q, 2, new StringBuilder());
            EnqueueMultiple(q, 4, 3);
            DequeueMultiple(q, 4, new StringBuilder());
            Assert.That(q.Count, Is.EqualTo(1));
        }

        /// <summary>
        /// Tests wrapping. 4 chars are Enqueued, then 2 are Dequeued, then
        /// 3 are Enqueued.  The last two of these should wrap around to the beginning
        /// of the array. Then all 5 are dequeued. The chars are the first 7 letters
        /// of the alphabet. The test verifies that they are dequeued correctly.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestIWrap()
        {
            Queue<char> q = new Queue<char>();
            EnqueueMultiple(q, 0, 4);
            StringBuilder sb = new StringBuilder();
            DequeueMultiple(q, 2, sb);
            EnqueueMultiple(q, 4, 3);
            DequeueMultiple(q, 5, sb);
            Assert.That(sb.ToString(), Is.EqualTo(_alphabet.Substring(0, 7)));
        }

        /// <summary>
        /// Tests that after 6 Enqueues, the capacity is 10.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestJExpandCapacity()
        {
            Queue<char> q = new Queue<char>();
            EnqueueMultiple(q, 0, 6);
            Assert.That(q.Capacity, Is.EqualTo(10));
        }

        /// <summary>
        /// Tests the Count after an expansion.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestKExpandCount()
        {
            Queue<char> q = new Queue<char>();
            EnqueueMultiple(q, 0, 6);
            Assert.That(q.Count, Is.EqualTo(6));
        }

        /// <summary>
        /// Tests that after 11 Enqueues, the capacity is 20.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestKDoubleExpandCapacity()
        {
            Queue<char> q = new Queue<char>();
            EnqueueMultiple(q, 0, 11);
            Assert.That(q.Capacity, Is.EqualTo(20));
        }

        /// <summary>
        /// Tests an expansion when the front of the queue is not at the beginning
        /// of the array. The first seven letters of the alphabet are enqueued, then
        /// four are dequeued. The next eight letters of the alphabet are then enqueued,
        /// causing an expansion. Finally, all letters are dequeued. The StringBuilder
        /// containing the dequeued letters should contain the first 15 letters of the
        /// alphabet.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestLExpand()
        {
            Queue<char> q = new Queue<char>();
            EnqueueMultiple(q, 0, 7);
            StringBuilder sb = new StringBuilder();
            DequeueMultiple(q, 4, sb);
            EnqueueMultiple(q, 7, 8);
            DequeueMultiple(q, 11, sb);
            Assert.That(sb.ToString(), Is.EqualTo(_alphabet.Substring(0, 15)));
        }
    }
}
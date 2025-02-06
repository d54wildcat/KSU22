/* QueueTest.cs
 * Author: Rod Howell
 */
using NUnit.Framework;
using System;
using System.Text;

namespace Ksu.Cis300.LinkedListLibrary.Tests
{
    /// <summary>
    /// A unit test class for the class Queue.
    /// </summary>
    [TestFixture]
    public class QueueTest
    {
        /// <summary>
        /// The lower-case English alphabet.
        /// </summary>
        private string _alphabet = "abcdefghijklmnopqrstuvwxyz";

        /// <summary>
        /// Tests that the Count property is indeed a property
        /// </summary>
        [Test, Timeout(1000)]
        public void TestCountPropertyExists()
        {
            Type type = new Queue<int>().GetType();
            Assert.That(type.GetProperty("Count") != null);
        }


        /// <summary>
        /// Enqueues onto the given queue n letters of the alphabet, starting with the one at location start.
        /// </summary>
        /// <param name="q">The queue.</param>
        /// <param name="start">The location in the alphabet of the first letter to enqueue.</param>
        /// <param name="n">The number of letters to enqueue.</param>
        private void EnqueueMultiple(Queue<char> q, int start, int n)
        {
            for (int i = start; i < start + n; i++)
            {
                q.Enqueue(_alphabet[i]);
            }
        }

        /// <summary>
        /// Dequeues n chars from the given queue, and appends them to the given StringBuilder.
        /// </summary>
        /// <param name="q">The queue.</param>
        /// <param name="n">The number of elements to dequeue.</param>
        /// <param name="sb">The StringBuilder.</param>
        private void DequeueMultiple(Queue<char> q, int n, StringBuilder sb)
        {
            for (int i = 0; i < n; i++)
            {
                sb.Append(q.Dequeue());
            }
        }

        /// <summary>
        /// Tests that a Peek on an empty queue throws an InvalidOperationException.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestAEmptyPeek()
        {
            Queue<int> q = new Queue<int>();
            Exception ex = null;
            try
            {
                q.Peek();
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.That(ex, Is.Not.Null.And.TypeOf(typeof(InvalidOperationException)));
        }

        /// <summary>
        /// Tests that a Dequeue on an empty stack throws an InvalidOperationException.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestBEmptyDequeue()
        {
            Queue<string> q = new Queue<string>();
            Exception ex = null;
            try
            {
                q.Dequeue();
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.That(ex, Is.Not.Null.And.TypeOf(typeof(InvalidOperationException)));
        }

        /// <summary>
        /// Tests whether the count is correctly updated after enqueueing twice.
        /// The count should be 2.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestCCountAfterEnqueue()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            Assert.That(q.Count, Is.EqualTo(2));
        }

        /// <summary>
        /// Tests whether the count is correctly updated after enqueueing three times
        /// and dequeueing once.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDCountAfterDequeue()
        {
            Queue<char> q = new Queue<char>();
            EnqueueMultiple(q, 0, 3);
            q.Dequeue();
            Assert.That(q.Count, Is.EqualTo(2));
        }

        /// <summary>
        /// Tests whether Peek returns the correct value after three items are enqueued onto
        /// the queue.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDSimplePeek()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            Assert.That(q.Peek(), Is.EqualTo(1));
        }

        /// <summary>
        /// Tests whether Dequeue returns the correct value after three items are enqueued onto
        /// the queue.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDSimpleDequeue()
        {
            Queue<char> q = new Queue<char>();
            EnqueueMultiple(q, 0, 3);
            Assert.That(q.Dequeue(), Is.EqualTo('a'));
        }

        /// <summary>
        /// Tests the results of a sequence of 6 Enqueues followed by 6 Dequeues.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestEMultipleDequeue()
        {
            Queue<char> q = new Queue<char>();
            EnqueueMultiple(q, 0, 6);
            StringBuilder sb = new StringBuilder();
            DequeueMultiple(q, 6, sb);
            Assert.That(sb.ToString(), Is.EqualTo("abcdef"));
        }

        /// <summary>
        /// Tests the result of a sequence of 4 Enqueues, followed by 4 Dequeues, followed
        /// by 5 Enqueues, followed by 3 Dequeues, followed by 3 Enqueues, followed by 5 Dequeues.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestFMultipleEnqueueDequeue()
        {
            Queue<char> q = new Queue<char>();
            EnqueueMultiple(q, 0, 4);
            StringBuilder sb = new StringBuilder();
            DequeueMultiple(q, 4, sb);
            EnqueueMultiple(q, 4, 5);
            DequeueMultiple(q, 3, sb);
            EnqueueMultiple(q, 9, 3);
            DequeueMultiple(q, 5, sb);
            Assert.That(sb.ToString(), Is.EqualTo(_alphabet.Substring(0, 12)));
        }
    }
}
/* Queue.cs
 * Author: Rod Howell
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.LinkedListLibrary
{
    /// <summary>
    /// A generic queue.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the queue.</typeparam>
    public class Queue<T>
    {
        /// <summary>
        /// The element at the front of the queue if the queue is nonempty.
        /// </summary>
        private LinkedListCell<T> _front;

        /// <summary>
        /// The element at the back of the queue if the queue is nonempty.
        /// </summary>
        private LinkedListCell<T> _back;

        /// <summary>
        /// Gets the number of elements in the queue.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Places the given element at the back of the queue.
        /// </summary>
        /// <param name="x">The element to enqueue.</param>
        public void Enqueue(T x)
        {
            LinkedListCell<T> cell = new LinkedListCell<T>();
            cell.Data = x;
            if (Count == 0)
            {
                _front = cell;
            }
            else
            {
                _back.Next = cell;
            }
            _back = cell;
            Count++;
        }

        /// <summary>
        /// Gets the element at the front of the queue.
        /// </summary>
        /// <returns>The element at the front of the queue.</returns>
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return _front.Data;
        }

        /// <summary>
        /// Removes the element at the front of the queue.
        /// </summary>
        /// <returns>The element removed.</returns>
        public T Dequeue()
        {
            T x = Peek();
            _front = _front.Next;
            Count--;
            return x;
        }
    }
}

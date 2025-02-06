/* Stack.cs
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
    /// A generic stack.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the stack.</typeparam>
    public class Stack<T>
    {
        /// <summary>
        /// The cell at the top of the stack.
        /// </summary>
        private LinkedListCell<T> _top = null;

        /// <summary>
        /// The number of elements in the stack.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Places the given element on the top of the stack.
        /// </summary>
        /// <param name="x">The element to push.</param>
        public void Push(T x)
        {
            LinkedListCell<T> cell = new LinkedListCell<T>();
            cell.Data = x;
            cell.Next = _top;
            _top = cell;
            Count++;
        }

        /// <summary>
        /// Gets the element at the top of the stack. If the stack is
        /// empty, throws an InvalidOperationException.
        /// </summary>
        /// <returns>The element at the top of the stack.</returns>
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return _top.Data;
        }

        /// <summary>
        /// Removes the element at the top of the stack.
        /// </summary>
        /// <returns>The element removed.</returns>
        public T Pop()
        {
            T x = Peek();
            _top = _top.Next;
            Count--;
            return x;
        }
    }
}

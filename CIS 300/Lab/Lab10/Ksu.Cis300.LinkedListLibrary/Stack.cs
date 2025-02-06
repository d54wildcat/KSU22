/*Stack.cs
 * Author: Dacey Wieland
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.LinkedListLibrary
{
    public class Stack<T>
    {
        private LinkedListCell<T> _element = null;
        private int _count = 0;
        
        /// <summary>
        /// Method that gets the Count of the elements in the stack
        /// </summary>
        public int Count
        {
            get { return _count; }
        }
        
        /// <summary>
        /// Adds the element to the top of the stack
        /// </summary>
        /// <param name="x"></param>
        public void Push(T x)
        {
            LinkedListCell<T> cell = new LinkedListCell<T>();
            cell.Data = x;
            cell.Next = _element;
            _element = cell;
            _count++;
        }
        /// <summary>
        /// Retrieves the element at the top of the stack without removing it
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public T Peek()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException();
            }
            return _element.Data;
        }
        /// <summary>
        /// Takes the top element out of the current stack
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            T x = Peek();
            _element = _element.Next;
            _count--;
            return x;
        }


    }
}

/* Stack.cs
 * Author: Dacey Wieland
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.StackLibrary
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Represents the type of elemts stored in the stack</typeparam>
    public class Stack<T>
    {
        /// <summary>
        /// Array used for stack creation
        /// </summary>
        private T[] _ugh = new T[5];

        public int Count { get; private set; }

        public int Capacity => _ugh.Length;
        /// <summary>
        /// Push adds a value to the bottom of the stack
        /// </summary>
        /// <param name="x">Object of T that we set to Push</param>
        public void Push(T x)
        {
            if (Capacity == Count)
            {
                T[] _twice = new T[Capacity * 2];
                _ugh.CopyTo(_twice, 0);
                _ugh = _twice;
            }
            _ugh[Count] = x;
            Count++;
        }
        /// <summary>
        /// Method that looks into the top of the stack without moving anything
        /// </summary>
        /// <returns> Top of the value without removing it</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return _ugh[Count-1];
        }
        /// <summary>
        /// Method that returns top elements from elements
        /// </summary>
        /// <returns>Value of the top elements</returns>
        public T Pop()
        {
            T x = Peek();
            Count--;
            _ugh[Count] = default;
            return x;
        }
        /// <summary>
        /// Method that clears the count of the array
        /// </summary>
        public void Clear()
        {
            _ugh = new T[5];
            Count = 0;
        }
    }
}

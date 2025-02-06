/*Queue.cs
 * Author: Dacey Wieland
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.QueueLibrary
{
    public class Queue<T>
    {
        private T[] _store = new T[5];
        private int _front = 0;
  
        public int Count
        {
             get; private set;
        }
        public int Capacity
        {
            get { return _store.Length; }
            
        }
        /// <summary>
        /// Places the given element at the back of the queue
        /// </summary>
        /// <param name="x"></param>
        public void Enqueue(T x)
        {
            if(Count == Capacity)
            {
                T[] _twice = new T[Capacity * 2];
                Array.Copy(_store, _front, _twice, _front, Capacity - _front);
                Array.Copy(_store, 0, _twice, Capacity, _front);
                _store = _twice;
            }
            int back = Count + _front;
            if (back >= Capacity)
            {
                back -= Capacity;
            }
            _store[back] = x;
            Count++;
        }
        /// <summary>
        ///  returns the element at the front of the queue.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public T Peek(){
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            else { return _store[_front]; }
        }
        /// <summary>
        /// removes and returns the element at the front of the queue.
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            T x = Peek();
            _store[_front] = default(T);
            _front++;
            if (_front == Capacity)
            {
                _front = 0;
            }
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            Count--;
            return x;
        }
    }
}

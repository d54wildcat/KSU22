
/*Dictionary.cs
 * Author: Dacey Wieland
 */using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.NameLookup
{
    public class Dictionary<TKey, TValue> where TKey : IComparable<TKey>
    {
        /// <summary>
        /// New cell that refers to the keys and their associated values
        /// </summary>
        private LinkedListCell<KeyValuePair<TKey, TValue>> _keys = new LinkedListCell<KeyValuePair<TKey, TValue>>();

        /// <summary>
        /// Method that takes in a key and check if it's null. If it is throws an exception
        /// </summary>
        /// <param name="k">Key being checked if null</param>
        /// <exception cref="ArgumentNullException">If the key is null</exception>
        private void isKeyNull(TKey k)
        {
            if (k == null)
            {
                throw new ArgumentNullException();
            }
        }
        /// <summary>
        /// Finds the last key in the cell that is less than the given key
        /// </summary>
        /// <param name="k">key being passed in</param>
        /// <returns>Returns the cell being passed in</returns>
        private LinkedListCell<KeyValuePair<TKey, TValue>> FindLastKey(TKey k)
        {
            LinkedListCell<KeyValuePair<TKey, TValue>> front = _keys;
            while (front.Next != null && front.Next.Data.Key.CompareTo(k) < 0)
            {
                front = front.Next;
            }
            return front;
        }
        /// <summary>
        /// Method to try and get the value from the key passed in
        /// </summary>
        /// <param name="k">Key being passed in</param>
        /// <param name="v">Value being passed in</param>
        /// <returns> returns the bool if the value was set to the key or not</returns>
        public bool TryGetValue(TKey k, out TValue v)
        {
            isKeyNull(k);
            LinkedListCell<KeyValuePair<TKey, TValue>> temp = FindLastKey(k);
            if (temp.Next == null || !temp.Next.Data.Key.Equals(k))
            {
                
                v = default(TValue);
                return false;
            }
            else
            {
                v = temp.Next.Data.Value;
                return true;
            }
        }
        /// <summary>
        /// Method that adds the new key value and cell to the new cell
        /// </summary>
        /// <param name="k">key being passed in</param>
        /// <param name="v">value being passed in</param>
        /// <exception cref="ArgumentException">Exception if the cell is not null and the key is less than the key</exception>
        public void Add(TKey k, TValue v)
        {
            isKeyNull(k);
            LinkedListCell<KeyValuePair<TKey, TValue>> temp = FindLastKey(k);
            if (temp.Next == null || !temp.Next.Data.Key.Equals(k))
            {
                
                LinkedListCell<KeyValuePair<TKey, TValue>> temps = new LinkedListCell<KeyValuePair<TKey, TValue>>();
                temps.Data = new KeyValuePair<TKey, TValue>(k, v);
                temps.Next = temp.Next;
                temp.Next = temps;
            }
            else
            {
                throw new ArgumentException();

            }
        }



    }
}

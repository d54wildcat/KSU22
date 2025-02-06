/* Dictionary.cs
 * Author: Rod Howell
 * Modified by: Dacey Wieland
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.NameLookup
{
    /// <summary>
    /// A generic dictionary in which keys must implement IComparable.
    /// </summary>
    /// <typeparam name="TKey">The key type.</typeparam>
    /// <typeparam name="TValue">The value type.</typeparam>
    public class Dictionary<TKey, TValue> where TKey : IComparable<TKey>
    {
        /// <summary>
        /// The keys and values in the dictionary, with a header cell.
        /// </summary>
        private List<KeyValuePair<TKey, TValue>> _elements = new List<KeyValuePair<TKey, TValue>>();

        /// <summary>
        /// Checks to see if the given key is null, and if so, throws an
        /// ArgumentNullException.
        /// </summary>
        /// <param name="key">The key to check.</param>
        private static void CheckKey(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Finds the last cell in _elements whose key is less than the given key, or the
        /// header cell if no keys are less than the given key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>The last cell whose key is less than the given key.</returns>
        private int Find(TKey key)
        {
            int start = 0;
            int end =  _elements.Count;
            
            while (start < end)
            {
                int average = (start + end) / 2;
                int result = _elements[average].Key.CompareTo(key);
                if (result > 0)
                {
                    start = average + 1;
                }
                else if (result < 0)
                {
                    end = average;
                }
                else if (result == 0)
                {
                    return average;
                }
            }
            return start;
        }

        /// <summary>
        /// Tries to get the value associated with the given key.
        /// </summary>
        /// <param name="k">The key.</param>
        /// <param name="v">The value associated with k, or the default value if
        /// k is not in the dictionary.</param>
        /// <returns>Whether k was found as a key in the dictionary.</returns>
        public bool TryGetValue(TKey k, out TValue v)
        {
            CheckKey(k);
            int p = Find(k);
            if (p == _elements.Count || _elements[p].Key.CompareTo(k) != 0)
            {
                v = default(TValue);
                return false;
            }
            else
            {
                v = _elements[p].Value;
                return true;
            }
        }

        /// <summary>
        /// Adds the given key with the given associated value.
        /// If the given key is already in the dictionary, throws an
        /// InvalidOperationException.
        /// </summary>
        /// <param name="k">The key.</param>
        /// <param name="v">The value.</param>
        public void Add(TKey k, TValue v)
        {
            CheckKey(k);
            int p = Find(k);
            if (p == _elements.Count || _elements[p].Key.CompareTo(k) !=  0)
            {
                _elements.Insert(p, new KeyValuePair<TKey, TValue>(k, v));
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}

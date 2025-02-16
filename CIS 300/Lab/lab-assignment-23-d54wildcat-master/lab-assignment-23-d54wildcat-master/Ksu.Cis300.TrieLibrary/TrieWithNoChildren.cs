﻿/* TrieWithNoChildren.cs
 * Author: Rod Howell
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    /// <summary>
    /// A trie with no children.
    /// </summary>
    public class TrieWithNoChildren : ITrie
    {
        /// <summary>
        /// Indicates whether this trie contains the empty string.
        /// </summary>
        private bool _hasEmptyString;

        /// <summary>
        /// Builds the result of adding the given string to this trie.
        /// This trie may or may not be changed.
        /// </summary>
        /// <param name="s">The string to add.</param>
        /// <returns>The resulting trie.</returns>
        public ITrie Add(string s)
        {
            if (s == "")
            {
                _hasEmptyString = true;
                return this;
            }
            else
            {
                return new TrieWithOneChild(s, _hasEmptyString);
            }
        }

        /// <summary>
        /// Determines whether this trie contains the given string.
        /// </summary>
        /// <param name="s">The string to look up.</param>
        /// <returns>Whether this trie contains s.</returns>
        public bool Contains(string s)
        {
            if (s == "")
            {
                return _hasEmptyString;
            }
            else
            {
                return false;
            }
        }
    }
}

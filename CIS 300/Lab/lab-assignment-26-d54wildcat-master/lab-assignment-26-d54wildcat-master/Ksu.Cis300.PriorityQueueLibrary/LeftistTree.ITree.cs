/* LeftistTree.ITree.cs
 * Author: Rod Howell
 * 
 * Note: This file contains only code relevant to drawing the tree.
 * It should not be modified.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KansasStateUniversity.TreeViewer2;

namespace Ksu.Cis300.PriorityQueueLibrary
{
    /// <summary>
    /// An immutable binary tree node that can draw itself.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the tree.</typeparam>
    public partial class LeftistTree<T> : ITree
    {
        /// <summary>
        /// Gets the children of this node.
        /// </summary>
        ITree[] ITree.Children
        {
            get
            {
                ITree[] children = new ITree[2];
                children[0] = LeftChild;
                children[1] = RightChild;
                return children;
            }
        }

        /// <summary>
        /// Gets whether this node is empty. Because empty trees will be represented by
        /// null, it always returns false.
        /// </summary>
        bool ITree.IsEmpty => false;

        /// <summary>
        /// Gets the object to be drawn as the contents of this node.
        /// </summary>
        object ITree.Root => Data;
    }
}

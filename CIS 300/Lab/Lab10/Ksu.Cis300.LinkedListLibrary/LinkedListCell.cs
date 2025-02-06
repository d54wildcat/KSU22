/*LinkedListCell.cs
 * Author: Dacey Wieland
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.LinkedListLibrary
{
    public class LinkedListCell<T>
    {
        private T _data;
        /// <summary>
        /// Method that gets or sets the data item stored in the cell
        /// </summary>
        public T Data
        {
            get{ return _data; }
            set { _data = value; }
        }
        private LinkedListCell<T> _next;
        /// <summary>
        /// Method that gets or sets the next item stored in a cell
        /// </summary>
        public LinkedListCell<T> Next
        {
            get { return _next; }
            set { _next = value; }
        }
    }
}

/* UserInterface.cs
 * Author: Rod Howell
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KansasStateUniversity.TreeViewer2;
using Ksu.Cis300.PriorityQueueLibrary;
using Ksu.Cis300.ImmutableBinaryTrees;
using System.IO;

namespace Ksu.Cis300.HuffmanTrees
{
    /// <summary>
    /// A GUI for a program that builds a Huffman tree for a given input file.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles a Click event on the "Select a File" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSelectFile_Click(object sender, EventArgs e)
        {

        }
    }
}

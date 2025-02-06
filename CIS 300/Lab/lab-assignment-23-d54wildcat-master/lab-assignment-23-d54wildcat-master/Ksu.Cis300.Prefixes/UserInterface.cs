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
using System.IO;
using Ksu.Cis300.TrieLibrary;

namespace Ksu.Cis300.Prefixes
{
    /// <summary>
    /// A GUI for a program to display all completions of a prefix.
    /// </summary>
    public partial class UserInterface : Form
    {
        private ITrie _words = new TrieWithNoChildren();

        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles a Click event on the "Open Word List" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _words = new TrieWithNoChildren();
                    using (StreamReader input = new StreamReader(uxOpenDialog.FileName))
                    {
                        while (!input.EndOfStream)
                        {
                            _words = _words.Add(input.ReadLine());
                        }
                    }
                    MessageBox.Show("Word list successfully read.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Handles a Click event on the "Look up Prefix" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxLookUp_Click(object sender, EventArgs e)
        {

        }
    }
}

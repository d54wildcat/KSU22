/*UserInterface.cs
 * Author : Dacey Wieland
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

namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// Class to edit Text Editor
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Method to Initialize the User Interface
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// method to open file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = uxOpenDialog.FileName;
                MessageBox.Show("Cannot Open File " + fileName);
            }
            
        }
        /// <summary>
        /// method to save file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uxSaveDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = uxOpenDialog.FileName;
                MessageBox.Show("Cannot Save File " + fileName);
            }
        }
    }
}


/* UserInterface.cs
 * Author: Rod Howell
 * Modified By : Dacey Wieland
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// A GUI for a simple text editor.
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
        /// Handles a Click event on the "Open . . ." file menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = uxOpenDialog.FileName;
                    uxEditBuffer.Text = File.ReadAllText(fileName);
                }
                catch (Exception ex)
                {
                    Exempt(ex);
                }
            }
        }

        /// <summary>
        /// Handles a Click event on the "Save As . . ." file menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSaveAs_Click(object sender, EventArgs e)
        {
            if (uxSaveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = uxSaveDialog.FileName;
                    File.WriteAllText(fileName, uxEditBuffer.Text);
                }
                catch (Exception ex)
                {
                    Exempt(ex);
                }
            }
        }
        /// <summary>
        /// Method that prints out an error message for the exception
        /// </summary>
        /// <param name="e">e is the exception that is thrown, and will be printed out
        /// </param> 
        private static void Exempt(Exception e)
        {
            MessageBox.Show("The following error occurred: " + e);
        }
    }
}

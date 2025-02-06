/* UserInterface.cs
 * Author: Rod Howell
 * Modified By : Dacey Wieland
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
                    uxTextBox.Text = File.ReadAllText(uxOpenDialog.FileName);
                }
                catch (Exception ex)
                {
                    ShowError(ex);
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
                    File.WriteAllText(uxSaveDialog.FileName, uxTextBox.Text);
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }

        /// <summary>
        /// Displays the given exception to the user.
        /// </summary>
        /// <param name="e">The exception to show.</param>
        private void ShowError(Exception e)
        {
            MessageBox.Show("The following error occurred: " + e);
        }
        /// <summary>
        /// Rotates the given character c n positions through the alphabet whose first
        /// letter is firstLetter and whose number of letters is alphabetLen. alphabetLen
        /// must be positive.
        /// </summary>
        /// <param name="c">The character to rotate.</param>
        /// <param name="n">The number of positions to rotate c.</param>
        /// <param name="firstLetter">The first letter of the alphabet.</param>
        /// <param name="alphabetLen">The number of letters in the alphabet.</param>
        /// <returns>The result of the rotation.</returns>
        private char Rotate(char c, int n, char firstLetter, int alphabetLen)
        {
            return (char)(firstLetter + (c - firstLetter + n) % alphabetLen);
        }
        /// <summary>
        /// Method used to Encrypt every letter thats passed in
        /// </summary>
        /// <param name="c"> Single character passed through the loop
        /// </param>
        /// <returns></returns>
        private char Encrypt(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                return Rotate(c, 13, 'a', 26);
            }
            else if (c >= 'A' && c <= 'Z')
            {
                return Rotate(c, 13, 'A', 26);
            }
            else
            {
                return c;
            }
        }
        /// <summary>
        /// Method to Encrypt using the String Method
        /// </summary>
        /// <param name="sender"> Object to send to the console
        /// </param>
        /// <param name="e"> Event to handle any Exceptions
        /// </param>
        private void UxEncryptString(object sender, EventArgs e)
        {
            string text = uxTextBox.Text;
            string result = "";
            for(int i = 0; i < text.Length; i++)
            {
                result += Encrypt(text[i]);
            }
            uxTextBox.Text = result;
        }
        /// <summary>
        /// Method to Encrypt using the StringBuilder Method
        /// </summary>
        /// <param name="sender"> Object to send to the console
        /// </param>
        /// <param name="e"> Event to handle any Exceptions
        /// </param>
        private void uxEnryptStringBuilder(object sender, EventArgs e)
        {
            string text = uxTextBox.Text;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                result.Append(Encrypt(text[i]));
            }
            uxTextBox.Text = result.ToString();
        }
    }
}

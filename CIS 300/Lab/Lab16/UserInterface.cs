/* UserInterface.cs
 * Author: Rod Howell
 * Modified by: Dacey Wieland
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
using System.Data.SqlTypes;

namespace Ksu.Cis300.FolderSizes
{
    /// <summary>
    /// A GUI for a program to find sizes of folders.
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
        /// Finds the total size of the folder
        /// </summary>
        /// <param name="folder">Folder that we pass into the method</param>
        /// <returns>Return the total size of the folder</returns>
        private static long TotalSize(DirectoryInfo folder)
        {
            long size = folder.GetDirectories().Length;
            try
            {
                foreach (FileInfo i in folder.GetFiles())
                {
                    size = size + i.Length;
                }
                foreach (DirectoryInfo dir in folder.GetDirectories())
                {
                    size = size + TotalSize(dir);
                }
                return size;
            }
            catch(Exception e)
            {
                return 0;
            }
            return size;
        }
        /// <summary>
        /// Sets the currently-analyzed folder to the given path name.
        /// </summary>
        /// <param name="folder">The path name for the folder to analyze.</param>
        private void SetCurrentFolder(DirectoryInfo folder)
        {
            uxCurrentFolder.Text = folder.FullName;
            long size = TotalSize(folder);
            uxSize.Text = size.ToString("N0");
            uxFolderList.Items.Clear();
            uxUp.Enabled = (folder.Parent != null);
            try
            {
                foreach (DirectoryInfo d in folder.GetDirectories())
                {
                    uxFolderList.Items.Add(d);
                }
            }
            catch
            {
                // If we can't access the sub-folders, we can't add them to the list.
            }
        }

        /// <summary>
        /// Event handler for the Set folder click
        /// </summary>
        /// <param name="sender">object that we are sending</param>
        /// <param name="e">parameter to check for exception</param>
        private void uxSetFolder_Click(object sender, EventArgs e)
        {
            if (uxFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                SetCurrentFolder(new DirectoryInfo(uxFolderBrowser.SelectedPath));
            }
        }

        /// <summary>
        /// The List box event handler
        /// </summary>
        /// <param name="sender">object to send</param>
        /// <param name="e">Exception handler</param>
        private void uxFolderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo d = (DirectoryInfo)uxFolderList.SelectedItem;
            if (d != null)
            {
                SetCurrentFolder(d);
            }
        }
        /// <summary>
        /// Up one level button event handler
        /// </summary>
        /// <param name="sender">object that we are sending</param>
        /// <param name="e">exception event e</param>
        private void uxUp_Click(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(uxCurrentFolder.Text);
            SetCurrentFolder(d.Parent);
        }
    }
}

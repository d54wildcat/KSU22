/*UserInterface.cs
 * Author; Dacey Wieland
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
using System.Drawing.Text;

namespace Ksu.Cis300.NameLookup
{
    public partial class UserInterface : Form
    {
        /// <summary>
        /// This is the GUI
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Private dictionary to run through the name frequency and rank
        /// </summary>
        private Dictionary<string, FrequencyAndRank> dict = new Dictionary<string, FrequencyAndRank>();
        /// <summary>
        /// Method that reads in the contents and sets them equal to the dictionary
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private Dictionary<string, FrequencyAndRank> FileContents(string fileName)
        {
            Dictionary<string, FrequencyAndRank> temp = new Dictionary<string, FrequencyAndRank>();
            using (StreamReader input = new StreamReader(uxOpenDialog.FileName))
            {
                while (!input.EndOfStream)
                {
                    string name = (input.ReadLine().Trim(' '));
                    float frequency = Convert.ToSingle(input.ReadLine());
                    int rank = Convert.ToInt32(input.ReadLine());
                    temp.Add(name, new FrequencyAndRank(frequency, rank));
                }
            }
            return temp;
        }
        /// <summary>
        /// Event handler for the Open file click
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
                        dict = FileContents(fileName);
                        MessageBox.Show("File successfully read.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        /// <summary>
        /// Event handler for the Lookup Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxLookup_Click(object sender, EventArgs e)
        {
            string name = uxName.Text.ToUpper().Trim(' ');
            if (dict.TryGetValue(name,  out FrequencyAndRank f))
            {
                uxFrequency.Text = f.Frequency.ToString();
                uxRank.Text = f.Rank.ToString();
                
            }
            else
            {
                MessageBox.Show("Name not found");
                uxFrequency.Text = "";
                uxRank.Text = "";
            }
            
        }
        
    }
}

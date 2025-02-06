/* UserInterface.cs
 * Author: Rod Howell
 * Modified By: Dacey Wieland
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

namespace Ksu.Cis300.CapitalGainCalculator
{
    /// <summary>
    /// A user interface for a simple captial gain calculator for a single stock commodity.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        /// 
        private Queue<decimal> _costs = new Queue<decimal>();
        public UserInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event Handler for when the user clicks Buy
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"></param>
        private void uxBuy_Click(object sender, EventArgs e)
        {
            decimal b = uxNumber.Value;
            decimal cost = uxCost.Value;
            for(int i = 0; i < b; i++)
            {
                _costs.Enqueue(cost);
            }
            uxOwned.Text = _costs.Count.ToString();
        }
        /// <summary>
        /// Handler for the sell click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSell_Click(object sender, EventArgs e)
        {
            decimal s = uxNumber.Value;
            decimal cost = uxCost.Value;
            if (s > _costs.Count)
            {
                MessageBox.Show("The user doesn't own that many shares");
            }
            else
            {
                decimal captgain = Convert.ToDecimal(uxGain.Text);
                for(decimal i = 0; i < s; i++)
                {
                    captgain += cost - _costs.Dequeue();
                }
                uxGain.Text = captgain.ToString();
                uxOwned.Text = _costs.Count.ToString();
                 
            }
        }
    }
}

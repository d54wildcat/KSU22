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

namespace Ksu.Cis300.Boggle
{
    /// <summary>
    /// A user interface for a program that finds all words in a randomly-generated Boggle Deluxe board.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The length and width of the grid.
        /// </summary>
        public const int GridSize = 5;

        /// <summary>
        /// The current board contents.
        /// </summary>
        private string[,] _board = new string[GridSize, GridSize];

        /// <summary>
        /// The word finder.
        /// </summary>
        private WordFinder _wordFinder;

        /// <summary>
        /// The dice.
        /// </summary>
        private string[][] _dice = new string[][]
        {
            new string[] { "A", "F", "I", "R", "S", "Y" },
            new string[] { "A", "D", "E", "N", "N", "N" },
            new string[] { "A", "E", "E", "E", "E", "M" },
            new string[] { "A", "A", "A", "F", "R", "S" },
            new string[] { "A", "E", "G", "M", "N", "N" },
            new string[] { "A", "A", "E", "E", "E", "E" },
            new string[] { "A", "E", "E", "G", "M", "U" },
            new string[] { "A", "A", "F", "I", "R", "S" },
            new string[] { "B", "J", "K", "Qu", "X", "Z" },
            new string[] { "C", "C", "E", "N", "S", "T" },
            new string[] { "C", "E", "I", "L", "P", "T" },
            new string[] { "C", "E", "I", "I", "L", "T" },
            new string[] { "C", "E", "I", "P", "S", "T" },
            new string[] { "D", "H", "L", "N", "O", "R" },
            new string[] { "D", "H", "L", "N", "O", "R" },
            new string[] { "D", "D", "H", "N", "O", "T" },
            new string[] { "D", "H", "H", "L", "O", "R" },
            new string[] { "E", "N", "S", "S", "S", "U" },
            new string[] { "E", "M", "O", "T", "T", "T" },
            new string[] { "E", "I", "I", "I", "T", "T" },
            new string[] { "F", "I", "P", "R", "S", "Y" },
            new string[] { "G", "O", "R", "R", "V", "W" },
            new string[] { "I", "P", "R", "R", "R", "Y" },
            new string[] { "N", "O", "O", "T", "U", "W" },
            new string[] { "O", "O", "O", "T", "T", "U" }
        };

        /// <summary>
        /// The random number generator.
        /// </summary>
        private Random _randomNumbers = new Random();

        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            GenerateNewBoard();
        }

        /// <summary>
        /// Generates a new game board.
        /// </summary>
        private void GenerateNewBoard()
        {
            int k = _dice.Length;
            for (int i = 0; i < GridSize; i++)
            {
                FlowLayoutPanel row = (FlowLayoutPanel)uxBoard.Controls[i];
                for (int j = 0; j < GridSize; j++)
                {
                    int loc = _randomNumbers.Next(k);
                    k--;
                    string[] temp = _dice[loc];
                    _dice[loc] = _dice[k];
                    _dice[k] = temp;
                    row.Controls[j].Text = _dice[k][_randomNumbers.Next(6)];
                    _board[i, j] = row.Controls[j].Text.ToString().ToLower();
                }
            }
        }

        /// <summary>
        /// Obtains the file of allowable words from the user when the form loads.
        /// </summary>
        /// <param name="e">Information about the Load event.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            uxOpenDialog.ShowDialog();
            try
            {
                _wordFinder = new WordFinder(_board, uxOpenDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Application.Exit();
            }
        }

        /// <summary>
        /// Handles a Click event on the New Board button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNewBoard_Click(object sender, EventArgs e)
        {
            GenerateNewBoard();
        }
    }
}

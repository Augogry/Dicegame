using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class inputNameForm : Form
    {
        private int numPlayers;
        private int difficulty;
        public inputNameForm()
        {
            InitializeComponent();
        }

        private void inputNameForm_Load(object sender, EventArgs e)
        {
            if (numPlayers == 1)
            {
                lblPlayer2.Text = "Difficulty:";
                txtbxPlayer2.Visible = false;
            }
            else
            {
                cmbxDifficulty.Visible = false;
            }
        }

        public void ShowDialog(int n)
        {
            numPlayers = n;
            ShowDialog();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (numPlayers == 1)
            {
                if (!(cmbxDifficulty.SelectedItem == null))
                {
                    if (cmbxDifficulty.SelectedItem.Equals("Easy"))
                    {
                        difficulty = 12;
                    }
                    else if (cmbxDifficulty.SelectedItem.Equals("Medium"))
                    {
                        difficulty = 13;
                    }
                    else if (cmbxDifficulty.SelectedItem.Equals("Advanced"))
                    {
                        difficulty = 14;
                    }
                    else if (cmbxDifficulty.SelectedItem.Equals("Difficult"))
                    {
                        difficulty = 15;
                    }
                    else
                    {
                        difficulty = 11;
                    }
                }
                else
                {
                    difficulty = 11; 
                }
            }
            else
            {
            }
            this.Hide();
        }

        public string getPlayer()
        {
            if (txtbxPlayer1.Text == null)
            {
                txtbxPlayer1.Text = "Player";
            }
            return txtbxPlayer1.Text;
        }

        public string getAdversary()
        {
            if (txtbxPlayer2.Visible == false)
            {
                return "NA";
            }
            else
            {
                return txtbxPlayer2.Text;
            }
        }

        public string getDifficulty()
        {
            return difficulty.ToString();
        }

        public string getItem()
        {
            if (cmbxItems.SelectedItem == null)
            {
                cmbxItems.SelectedItem = "Dagger";
            }
            return cmbxItems.SelectedItem.ToString();
        }
    }
}

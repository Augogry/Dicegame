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
    public partial class TownForm : Form
    {
        public TownForm()
        {
            InitializeComponent();
        }

        private void pnlMarket_MouseHover(object sender, EventArgs e)
        {
            lblMarket.ForeColor = Color.Gold;
            pnlMarket.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pnlStats_MouseHover(object sender, EventArgs e)
        {
            lblStats.ForeColor = Color.Gold;
            pnlStats.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pnFight_MouseHover(object sender, EventArgs e)
        {
            lblFight.ForeColor = Color.Gold;
            pnlFight.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pnlMarket_Click(object sender, EventArgs e)
        {
            marketForm mf = new marketForm();
            mf.ShowDialog();
        }

        private void pnlStats_Click(object sender, EventArgs e)
        {

        }

        private void pnlFight_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlMarket_MouseLeave(object sender, EventArgs e)
        {
            lblMarket.ForeColor = Color.White;
            pnlMarket.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pnlStats_MouseLeave(object sender, EventArgs e)
        {
            lblStats.ForeColor = Color.White;
            pnlStats.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pnlFight_MouseLeave(object sender, EventArgs e)
        {
            lblFight.ForeColor = Color.White;
            pnlFight.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}

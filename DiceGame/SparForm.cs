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
    public partial class SparForm : Form
    {
        private int playerRoll, enemyRoll;
        private string playerName, monsterName;
        private int incrementer = 1;
        private string path, pAction, mAction;


        public SparForm()
        {
            InitializeComponent();
        }

        private void SparForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(System.IO.Path.GetDirectoryName(Application.ExecutablePath));
            lblp1Roll.Text = playerName;
            lblp2Roll.Text = monsterName;
            setPictures();
            loadInfo();
        }

        public void ShowDialog(int p, int e, string p1, string p2)
        {
            playerRoll = p;
            enemyRoll = e;
            playerName = p1;
            monsterName = p2;
            ShowDialog();
        }

        public void loadInfo()
        {
            cRoll.Text = playerRoll.ToString();
            if (playerRoll == 1000000)
            {
                cRoll.Text = "❂";
            }
            eRoll.Text = enemyRoll.ToString();

            if (playerRoll > enemyRoll)
            {
                characterActions("attack", "hurt");
                lblHit.Text = playerName + " rolled higher. "+monsterName+" takes damage!";
            }
            else if (enemyRoll > playerRoll)
            {
                characterActions("hurt", "attack");
                lblHit.Text = monsterName + " rolled higher. " + playerName + " takes damage!";
            }
            else
            {
                characterActions("idle", "idle");
                lblHit.Text = "Same value. No damage dealt!";
            }
        }

        public char whoHit()
        {
            if (playerRoll > enemyRoll)
            {
                return 'p';
            }
            else if (enemyRoll > playerRoll)
            {
                return 'e';
            }
            else
            {
                return 'n';
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setPictures()
        {
            try
            {
                path = "Avatars\\" + monsterName + "\\" + monsterName.ToLower() + "_idle(1).png";
                picBoxEnemy.ImageLocation = @path;

                path = "Avatars\\Player\\player_idle(1).png";
                picBoxCharacter.ImageLocation = @path;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
            

        private void characterActions(string p, string m)
        {
            pAction = p;
            mAction = m;
        }

        private void tmrAction_Tick(object sender, EventArgs e)
        {
            if (incrementer > 20)
            {
                tmrAction.Enabled = false;
            }
            else
            { 
                path = "Avatars\\" + "Player" + "\\" + "player" + "_" + pAction + "(" + incrementer + ").png";
                picBoxCharacter.ImageLocation = @path;
                path = "Avatars\\" + monsterName + "\\" + monsterName.ToLower() + "_" + mAction + "(" + incrementer + ").png";
                
                picBoxEnemy.ImageLocation = @path;
            }
           
            incrementer++;
        }
    }
}

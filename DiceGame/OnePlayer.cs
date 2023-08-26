 using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace DiceGame
{
    public partial class  OnePlayer : Form
    {
        public OnePlayer()
        {
            InitializeComponent();
        }
        private Character player;
        private Character monster;
        private int[] faces;
        private string[] tempFaces;
        private int[] monsterFaces;
        private bool generated = false;
        private bool faceChanged = true;
        private ChangeFacesForm cf;
        Random rand = new Random();
        int numRounds = 0;
        int lastUsed = 0;
        string path = "";

        private void DiceGame_Load(object sender, EventArgs e)
        {
            setPictures();
            if (faceChanged == true)
            {
                btnFaces.Enabled = false;
            }
            lblCharName.Text = player.Name;
            lblCharTotal.Text = player.MaxPoints.ToString();
            progBarChar.Maximum = player.MaxHp;
            progBarChar.Value = player.CurrentHp;
            setMonster();
            progBarEnemy.Maximum = monster.MaxHp;
            progBarEnemy.Value = monster.CurrentHp;
            lblEnemyName.Text = monster.Name;
            lblEnemyTotal.Text = monster.MaxPoints.ToString();
            if (generated == false)
            {
                generateFaces();
                generated = true;
            }
            numRounds = 1;
            updateSchedule();
            updateHealthBars();
            toolTipSpecial.SetToolTip(btnSpecial, player.Equipped.ItemName);
        }
        public void ShowDialog(Character plyr, Character mnstr)
        {
            player = plyr;
            monster = mnstr;
            ShowDialog();
        }
        private void generateFaces()
        {
            faces = new int[] { 0, 0, 0, 0, 0, 0 };
            if(generated==false)
            {
                int highFace = rand.Next(5);
                faces.SetValue(player.MaxPoints, highFace);
            }
            cFace1.Text = faces[0].ToString();
            cFace2.Text = faces[1].ToString();
            cFace3.Text = faces[2].ToString();
            cFace4.Text = faces[3].ToString();
            cFace5.Text = faces[4].ToString();
            cFace6.Text = faces[5].ToString();
            cSchedule1.Text = player.Schedule[0].ToString();
            cSchedule2.Text = player.Schedule[1].ToString();
            cSchedule3.Text = player.Schedule[2].ToString();
        }

        private void generateFaces(int[] values)
        {
            cFace1.Text = values[0].ToString();
            cFace2.Text = values[1].ToString();
            cFace3.Text = values[2].ToString();
            cFace4.Text = values[3].ToString();
            cFace5.Text = values[4].ToString();
            cFace6.Text = values[5].ToString();
        }

        private void generateFaces(string[] values)
        {
            cFace1.Text = values[0];
            cFace2.Text = values[1];
            cFace3.Text = values[2];
            cFace4.Text = values[3];
            cFace5.Text = values[4];
            cFace6.Text = values[5];
        }

        private void setMonster()
        {
            monsterFaces = new int[6];
            int position = rand.Next(5);
            int maxValue = 0;
            switch (monster.MaxPoints)
            {
                case 11:
                    maxValue = rand.Next(7, 8);
                    break;
                case 12:
                    maxValue = rand.Next(7, 8);
                    break;
                case 13:
                    maxValue = rand.Next(6, 7);
                    break;
                case 14:
                    maxValue = rand.Next(5, 7);
                    break;
                case 15:
                    maxValue = rand.Next(4, 8);
                    break;
            }
            monsterFaces[position] = maxValue;
            int remainder = monster.MaxPoints - maxValue;
            int condition = 0;
            position = 0;
            while (remainder > 0)
            {
                if (position > 5)
                {
                    position = 0;
                }
                if (monsterFaces[position] <= condition)
                {
                    int chance = rand.Next(1, 101);
                    if (chance < 51)
                    {
                        monsterFaces[position]++;
                        remainder--;
                    }
                }
                position++;
                condition++;
            }

            eSchedule1.Text = "0";
            eSchedule2.Text = "0";
            eSchedule3.Text = "0";
            eFace1.Text = monsterFaces[0].ToString();
            eFace2.Text = monsterFaces[1].ToString();
            eFace3.Text = monsterFaces[2].ToString();
            eFace4.Text = monsterFaces[3].ToString();
            eFace5.Text = monsterFaces[4].ToString();
            eFace6.Text = monsterFaces[5].ToString();
        }

        private void btnFaces_Click(object sender, EventArgs e)
        {
            cf = new ChangeFacesForm();
            cf.Faces = faces;
            cf.ShowDialog();
            this.faces = cf.returnFaces();
            generateFaces(faces);
            btnFaces.Enabled = false;
        }

        private void updateSchedule()
        {
            int scheduleValue = numRounds % 3;
            if (scheduleValue == 1)
            {
                cSchedule1.BackColor = System.Drawing.Color.Green;
                cSchedule2.BackColor = System.Drawing.Color.White;
                cSchedule3.BackColor = System.Drawing.Color.White;

                if (cSchedule1.Text == "1")
                {
                    btnFaces.Enabled = true;
                }
                else
                {
                    btnFaces.Enabled = false;
                }
            }
            else if (scheduleValue == 2)
            {
                cSchedule1.BackColor = System.Drawing.Color.White;
                cSchedule2.BackColor = System.Drawing.Color.Green;
                cSchedule3.BackColor = System.Drawing.Color.White;

                if (cSchedule2.Text == "1")
                {
                    btnFaces.Enabled = true;
                }
                else
                {
                    btnFaces.Enabled = false;
                }
            }
            else
            {
                cSchedule1.BackColor = System.Drawing.Color.White;
                cSchedule2.BackColor = System.Drawing.Color.White;
                cSchedule3.BackColor = System.Drawing.Color.Green;

                if (cSchedule3.Text == "1")
                {
                    btnFaces.Enabled = true;
                }
                else
                {
                    btnFaces.Enabled = false;
                }
            }

            
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            monsterTurn();
            Button[] buttons = new Button[6] { cFace1, cFace2, cFace3, cFace4, cFace5, cFace6 };
            Button[] ebuttons = new Button[6] { eFace1, eFace2, eFace3, eFace4, eFace5, eFace6 };
            int cRoll = Int32.Parse(buttons[rand.Next(5)].Text);
            if (cRoll.Equals("❂"))
            {
                cRoll = 1000000;
            }
            int eRoll = Int32.Parse(ebuttons[rand.Next(5)].Text);
            SparForm sf = new SparForm();
            sf.ShowDialog(cRoll, eRoll, player.Name, monster.Name);   
            char whoHit = sf.whoHit();
            if (whoHit == 'p')
            {
                monster.CurrentHp -= player.Attack;
            }
            else if (whoHit == 'e')
            {
                player.CurrentHp -= monster.Attack;
            }
            updateHealthBars();
            deadAnimation();
            if (player.CurrentHp <= 0)
            {
                MessageBox.Show("You have died! \nThanks for Playing Dice Game.");
                this.Close();
            }
            else if (monster.CurrentHp <= 0)
            {
                MessageBox.Show("The " + monster.Name + " is dead! \nYou win!");
                btnSkip_Click(sender, e);
            }
            numRounds++;
            updateSchedule();
            //Verify for special button
            if (numRounds - lastUsed < player.Equipped.Cooldown)
            {
                btnSpecial.Enabled = false;
                lblCountdown.Text = (player.Equipped.Cooldown - (numRounds - lastUsed)).ToString();
            }
            else
            {
                btnSpecial.Enabled = true;
                lblCountdown.Text = "Ready!";
            }
            if (lastUsed == 0)
            {
                btnSpecial.Enabled = true;
                lblCountdown.Text = "Ready!";
            } 
            //verify for end of buff
            string ID = player.Equipped.SpecialID;
            if (ID.Equals("B2") || ID.Equals("C1"))
            {
                if (numRounds - lastUsed == 1)
                {
                    generateFaces(faces);
                }
            }
            else if (ID.Equals("B3") || ID.Equals("S1"))
            {
                if (numRounds - lastUsed == 2)
                {
                    generateFaces(faces);
                }
            }
        }

        private void monsterTurn()
        {
            int scheduleValue = numRounds % 3;
            if (scheduleValue == 1)
            {
                eSchedule1.BackColor = System.Drawing.Color.Green;
                eSchedule2.BackColor = System.Drawing.Color.White;
                eSchedule3.BackColor = System.Drawing.Color.White;
            }
            else if (scheduleValue == 2)
            {
                eSchedule1.BackColor = System.Drawing.Color.White;
                eSchedule2.BackColor = System.Drawing.Color.Green;
                eSchedule3.BackColor = System.Drawing.Color.White;
            }
            else
            {
                eSchedule1.BackColor = System.Drawing.Color.White;
                eSchedule2.BackColor = System.Drawing.Color.White;
                eSchedule3.BackColor = System.Drawing.Color.Green;
            }
        }

        private void updateHealthBars()
        {
            progBarChar.Value = player.CurrentHp;
            lblCharHealth.Text = player.CurrentHp + "   /   " + player.MaxHp;
            progBarEnemy.Value = monster.CurrentHp;
            lblEnemyHealth.Text = monster.CurrentHp + "   /   " + monster.MaxHp;
        }

        public Character getPlayer()
        {
            return player;
        }

        public Character getMonster()
        {
            return monster;
        }

        private void OnePlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            var result = MessageBox.Show("Are you sure you want to exit the game?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thanks for playing!");
                Application.Exit();
                exitGame = true;
            }
            else
            {
                e.Cancel = true;
                exitGame = false;
            }*/
            btnKill_Click(sender, e);
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            if (btnSpecial.Enabled == false) { }
            else
            {
                string itemID = player.Equipped.SpecialID;
                UseSpecialForm usf = new UseSpecialForm();
                switch (itemID)
                {
                    case "B1"://Sword
                        
                        break;
                    case "B2"://Dagger
                        usf.ShowDialog("Dagger", "Select one face to increase by one point for one round", faces, 1, 1);
                        break;
                    case "B3"://shortsword
                        usf.ShowDialog("ShortSword", "Select two faces to increase by two points for two rounds", faces, 2, 2);
                        break;
                    case "S1"://Staff
                        usf.ShowDialog("Staff", "Select two faces. One will be increased by 1 point and the other will be a * for one round", faces, 1, 2);
                        break;
                    case "C1"://Club
                        usf.ShowDialog("Club", "Select a face to add two to one side for one round", faces, 2, 1);
                        break;
                }
                tempFaces = usf.getChanges();
                generateFaces(tempFaces);
                lastUsed = numRounds;
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            monster.CurrentHp = 0;
            updateHealthBars();
            //MessageBox.Show("The " + monster.Name + " is dead! \nYou win!");
            this.Close();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    
        private void setPictures()
        {
            path = "Avatars\\" + monster.Name + "\\" + monster.Name.ToLower() + "_idle(1).png";
            MessageBox.Show(path);
            picBoxEnemy.ImageLocation = @path;

            path = "Avatars\\Player\\player_idle(1).png";   
            picBoxCharacter.ImageLocation = @path;
        }

        private void deadAnimation()
        {
            Timer tmr = new Timer();
            tmr.Interval = 1000;
            if (player.CurrentHp <= 0 || monster.CurrentHp<=0)
            {
                if (player.CurrentHp <= 0)
                {
                    for (int i = 1; i < 20; i++)
                    {
                        path = "Avatars\\Player\\player_die(" + i + ").png";
                        picBoxCharacter.ImageLocation = @path;
                        tmr.Enabled = true;
                    }
                }
                else
                {
                    for (int i = 1; i < 20; i++)
                    {
                        path = "Avatars\\"+monster.Name+"\\"+monster.Name.ToLower()+"_die(" + i + ").png";
                        picBoxEnemy.ImageLocation = @path;
                        tmr.Enabled = true;
                    }
                }
                tmr.Interval = 5000;
                tmr.Enabled = true;
            }
        }
    }
}

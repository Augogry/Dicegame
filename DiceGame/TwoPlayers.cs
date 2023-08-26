using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace DiceGame
{
    public partial class TwoPlayers : Form
    {
        public TwoPlayers()
        {
            InitializeComponent();
        }

        private string p1Name;
        private string p2Name;
        private Character player1;
        private Character player2;
        private int[] p1Faces;
        private int[] p2Faces;
        private bool generated = false;
        private int[] p1Schedule;
        private int[] p2Schedule;
        private ChangeFacesForm cf;
        Random rand = new Random();
        int numRounds;

        public void ShowDialog(Character p1, Character p2)
        {
            player1 = p1;
            player2 = p2;
            ShowDialog();
        }
        private void DiceGameTwo_Load(object sender, EventArgs e)
        {
            numRounds = 1;
            lblP1Name.Text = p1Name;
            lblEnemyName.Text = p2Name;
            lblP1Total.Text = player1.MaxPoints.ToString();
            lblP2Total.Text = player2.MaxPoints.ToString();
            progBarP1.Maximum = player1.MaxHp;
            progBarP1.Value = player1.CurrentHp;
            progBarP2.Maximum = player2.MaxHp;
            progBarP2.Value = player2.CurrentHp;           
            if (generated == false)
            {
                generateFaces();
                generated = true;
            }
            numRounds = 1;
            updateSchedule();
        }

        private void generateFaces()
        {
            p1Faces = new int[] { 0, 0, 0, 0, 0, 0 };
            p2Faces = new int[] { 0, 0, 0, 0, 0, 0 };
            p1Schedule = new int[3];
            p2Schedule = new int[3];
            fillSchedules(p1Schedule);
            fillSchedules(p2Schedule);
            if (generated == false)
            {
                int highFace = rand.Next(5);
                p1Faces.SetValue(player1.MaxPoints, highFace);
                highFace = rand.Next(5);
                p2Faces.SetValue(player2.MaxPoints, highFace);
            }
            p1Face1.Text = p1Faces[0].ToString();
            p1Face2.Text = p1Faces[1].ToString();
            p1Face3.Text = p1Faces[2].ToString();
            p1Face4.Text = p1Faces[3].ToString();
            p1Face5.Text = p1Faces[4].ToString();
            p1Face6.Text = p1Faces[5].ToString();
            p1Schedule1.Text = p1Schedule.ElementAt(0).ToString();
            p1Schedule2.Text = p1Schedule.ElementAt(1).ToString();
            p1Schedule3.Text = p1Schedule.ElementAt(2).ToString();
            p2Face1.Text = p2Faces[0].ToString();
            p2Face2.Text = p2Faces[1].ToString();
            p2Face3.Text = p2Faces[2].ToString();
            p2Face4.Text = p2Faces[3].ToString();
            p2Face5.Text = p2Faces[4].ToString();
            p2Face6.Text = p2Faces[5].ToString();
            p2Schedule1.Text = p2Schedule.ElementAt(0).ToString();
            p2Schedule2.Text = p2Schedule.ElementAt(1).ToString();
            p2Schedule3.Text = p2Schedule.ElementAt(2).ToString();
        }

        private void fillSchedules(int[] schedule)
        {
            int randomArray = rand.Next(2);
            if (randomArray == 0)
            {
                schedule[0] = 1;
                schedule[1] = 1;
                schedule[2] = 0;
            }
            else if (randomArray == 1)
            {
                schedule[0] = 1;
                schedule[1] = 0;
                schedule[2] = 1;
            }
            else
            {
                schedule[0] = 0;
                schedule[1] = 1;
                schedule[2] = 1;
            }
        }

        private void updateFaces(int[] values, int character)
        {
            if (character == 1)
            {
                p1Faces = values;
                p1Face1.Text = p1Faces[0].ToString();
                p1Face2.Text = p1Faces[1].ToString();
                p1Face3.Text = p1Faces[2].ToString();
                p1Face4.Text = p1Faces[3].ToString();
                p1Face5.Text = p1Faces[4].ToString();
                p1Face6.Text = p1Faces[5].ToString();
            }
            else
            {
                p2Faces = values;
                p2Face1.Text = p2Faces[0].ToString();
                p2Face2.Text = p2Faces[1].ToString();
                p2Face3.Text = p2Faces[2].ToString();
                p2Face4.Text = p2Faces[3].ToString();
                p2Face5.Text = p2Faces[4].ToString();
                p2Face6.Text = p2Faces[5].ToString();
            }
            
        }

        private void updateSchedule()
        {
            int scheduleValue = numRounds % 3;
            if (scheduleValue == 1)
            {
                p1Schedule1.BackColor = System.Drawing.Color.Green;
                p1Schedule2.BackColor = System.Drawing.Color.White;
                p1Schedule3.BackColor = System.Drawing.Color.White;
                p2Schedule1.BackColor = System.Drawing.Color.Green;
                p2Schedule2.BackColor = System.Drawing.Color.White;
                p2Schedule3.BackColor = System.Drawing.Color.White;

                if (p1Schedule1.Text == "1")
                {
                    btnChangeFacesP1.Enabled = true;
                }
                else
                {
                    btnChangeFacesP1.Enabled = false;
                }
                if (p2Schedule1.Text == "1")
                {
                    btnChangeFacesP2.Enabled = true;
                }
                else
                {
                    btnChangeFacesP2.Enabled = false;
                }
            }
            else if (scheduleValue == 2)
            {
                p1Schedule1.BackColor = System.Drawing.Color.White;
                p1Schedule2.BackColor = System.Drawing.Color.Green;
                p1Schedule3.BackColor = System.Drawing.Color.White;
                p2Schedule1.BackColor = System.Drawing.Color.White;
                p2Schedule2.BackColor = System.Drawing.Color.Green;
                p2Schedule3.BackColor = System.Drawing.Color.White;

                if (p1Schedule2.Text == "1")
                {
                    btnChangeFacesP1.Enabled = true;
                }
                else
                {
                    btnChangeFacesP1.Enabled = false;
                }
                if (p2Schedule2.Text == "1")
                {
                    btnChangeFacesP2.Enabled = true;
                }
                else
                {
                    btnChangeFacesP2.Enabled = false;
                }
            }
            else
            {
                p1Schedule1.BackColor = System.Drawing.Color.White;
                p1Schedule2.BackColor = System.Drawing.Color.White;
                p1Schedule3.BackColor = System.Drawing.Color.Green;
                p2Schedule1.BackColor = System.Drawing.Color.White;
                p2Schedule2.BackColor = System.Drawing.Color.White;
                p2Schedule3.BackColor = System.Drawing.Color.Green;

                if (p1Schedule3.Text == "1")
                {
                    btnChangeFacesP1.Enabled = true;
                }
                else
                {
                    btnChangeFacesP1.Enabled = false;
                }
                if (p2Schedule3.Text == "1")
                {
                    btnChangeFacesP2.Enabled = true;
                }
                else
                {
                    btnChangeFacesP2.Enabled = false;
                }
            }
        }

        private void updateHealthBars()
        {
            progBarP1.Value = player1.CurrentHp;
            progBarP2.Value = player2.CurrentHp;
        }
  
        private void maskPlayerTurn(PictureBox picbx, string froOrBack)
        {
            if (froOrBack.Equals("front"))
            {
                picbx.BringToFront();
                picbx.BackgroundImage = new Bitmap(@"look.png");     
            }
            else if (froOrBack.Equals("back"))
            {
                picbx.BackgroundImage = null;
                picbx.SendToBack();
            }
        }

        private void btnChangeFacesP1_Click(object sender, EventArgs e)
        {
            cf = new ChangeFacesForm();
            cf.Faces = p1Faces;
            cf.ShowDialog();
            updateFaces(cf.returnFaces(), 1);
            btnChangeFacesP1.Enabled = false;
        }

        private void btnChangeFacesP2_Click(object sender, EventArgs e)
        {
            cf = new ChangeFacesForm();
            cf.Faces = p2Faces;
            cf.ShowDialog();
            updateFaces(cf.returnFaces(), 2); 
            btnChangeFacesP2.Enabled = false;
        }

        private void btnReadyP1_Click(object sender, EventArgs e)
        {
            maskPlayerTurn(picbxP1Background, "front");
            maskPlayerTurn(picbxP2Background, "back");
        }

        private void btnReadyP2_Click(object sender, EventArgs e)
        {
            maskPlayerTurn(picbxP2Background, "front");
            int p1Roll = p1Faces[rand.Next(5)];
            int p2Roll = p2Faces[rand.Next(5)];
            SparForm sf = new SparForm();
            sf.ShowDialog(p1Roll, p2Roll, p1Name, p2Name);
            char whoHit = sf.whoHit();
            if (whoHit == 'p')
            {
                player2.CurrentHp -= player1.Attack;
            }
            else if (whoHit == 'e')
            {
                player1.CurrentHp -= player2.Attack;
            }
            updateHealthBars();
            if (player1.CurrentHp <= 0)
            {
                maskPlayerTurn(picbxP1Background, "back");
                maskPlayerTurn(picbxP2Background, "back");
                MessageBox.Show(player1.Name+" has died1\n"+player2.Name+" wins!");               
            }
            else if (player2.CurrentHp <= 0)
            {
                maskPlayerTurn(picbxP1Background, "back");
                maskPlayerTurn(picbxP2Background, "back");
                MessageBox.Show(player2.Name+" has died1\n"+player1.Name+" wins!");
            }
            else
            {
                numRounds++;
                updateSchedule();
                maskPlayerTurn(picbxP1Background, "back");
            }
        }

        
    }
}

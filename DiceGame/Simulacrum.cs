using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Simulacrum : Form
    {
        Random rand = new Random();
        Character player = new Character("Player");
        Character enemy = new Character("Enemy");
        int[] faces = new int[6];
        int[] enemyFaces = new int[6];
        int[] schedule;
        int schedulePoints = 0;
        string arrangement = "";
        decimal maxFaceValue = 0;
        int gold = 0;

        public Simulacrum()
        {
            InitializeComponent();
        }

        private void Simulacrum_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtbxValues, "e.g 1,1,0,1 or 0,1,1. The number of values should correspond to the number of faces you selected above");
            toolTip2.SetToolTip(txtbxEFaces, "e.g 3,13,0,0,4,2. This must contain six values seperated by commas");
            rdbtnCustom.Checked = true;
            setButtons();
        }

        private void setButtons()
        {
            if (rdbtnCustom.Checked == true)
            {
                txtbxEMaxPoints.Enabled = false;
                txtbxEFaces.Enabled = true;
            }
            else if (rdbtnRandom.Checked == true)
            {
                txtbxEMaxPoints.Enabled = true;
                txtbxEFaces.Enabled = false;
            }
            else
            {
                txtbxEMaxPoints.Enabled = false;
                txtbxEFaces.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            setButtons();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            setButtons();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //Process Starts
            if (chkbxShowSteps.Checked == true && Int32.Parse(txtbxNumFights.Text) > 5)
            {
                MessageBox.Show("Thats too many steps to show! Unchecking 'Steps' option");
                chkbxShowSteps.Checked = false;
            }
            Stopwatch stp = new Stopwatch();
            stp.Start();
            //Generate Schedule

            int numFights = Int32.Parse(txtbxNumFights.Text);
            arrangement = cmbxArrangement.SelectedItem.ToString();
            schedulePoints = Int32.Parse(cmbxFaces.SelectedItem.ToString());

            string[] values = txtbxValues.Text.Split(',');
            schedule = new int[schedulePoints];
            for (int i = 0; i < values.Length; i++)
            {
                schedule[i] = Int32.Parse(values[i]);
            }
            //Generate faces
            faces[5] = Int32.Parse(txtbxMaxPoints.Text);
            //generate enemy
            if (rdbtnCustom.Checked == true)
            {
                string[] tokens = txtbxEFaces.Text.Split(',');
                for (int i = 0; i < tokens.Length; i++)
                {
                    enemyFaces[i] = Int32.Parse(tokens[i]);
                }
            }
            else
            {
                int eMaxPoints = Int32.Parse(txtbxEMaxPoints.Text);
                int highValue = ((7 * eMaxPoints) / 10);
                int remainder = eMaxPoints - highValue;
                enemyFaces[5] = highValue;
                for (int i = 0; i < 5; i++)
                {
                    if (remainder > 0)
                    {
                        int chance = rand.Next(1, 100);
                        if (chance < 51)
                        {
                            enemyFaces[i]++;
                            remainder--;
                        }
                        if (i == 4 && remainder > 0)
                        {
                            i = -1;
                        }
                    }
                }
            }

            //Fight
            int numRounds = 0;
            int wins = 0;
            int losses = 0;
            List<int> rounds = new List<int>();
            while (numFights > 0)
            {
                while (whoDied() == null)
                {
                    whoHit(playerTurn(numRounds), enemyTurn(numRounds));
                    numRounds++;
                }
                gold += (((3*(numRounds/100))+(enemy.MaxPoints/200))*enemy.MaxHp);
                rounds.Add(numRounds);
                if (whoDied().Equals("player"))
                {
                    losses++;
                }
                else if (whoDied().Equals("enemy"))
                {
                    wins++;
                    gold += (((3 * (numRounds / 100)) + (enemy.MaxPoints / 200)) * enemy.MaxHp);
                    //bMessageBox.Show(""+ gold);
                }
                //resetting
                player.CurrentHp = player.MaxHp;
                enemy.CurrentHp = enemy.MaxHp; 
                numFights -= 1;
                numRounds = 0;
                for (int i = 0; i <= 4; i++)
                {
                    faces[i] = 0;
                }
                faces[5] = Int32.Parse(txtbxMaxPoints.Text);
                if (rdbtnCustom.Checked == true)
                {
                    string[] tokens = txtbxEFaces.Text.Split(',');
                    for (int i = 0; i < tokens.Length; i++)
                    {
                        enemyFaces[i] = Int32.Parse(tokens[i]);
                    }
                }
                else
                {
                    int eMaxPoints = Int32.Parse(txtbxEMaxPoints.Text);
                    int highValue = ((19 * eMaxPoints) / 32);
                    int remainder = eMaxPoints - highValue;
                    for (int i = 0; i <= 4; i++)
                    {
                        enemyFaces[i] = 0;
                    }
                    enemyFaces[5] = highValue;
                    for (int i = 0; i < 5; i++)
                    {
                        if (remainder > 0)
                        {
                            int chance = rand.Next(1, 100);
                            if (chance < 51)
                            {
                                enemyFaces[i]++;
                                remainder--;
                            }
                            if (i == 4 && remainder > 0)
                            {
                                i = -1;
                            }
                        }
                    }
                }
            }
            stp.Stop();
            TimeSpan ts = stp.Elapsed;
            string time = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            string results = "Date and Time: " + DateTime.Now + "\nProcessing Time: " + time +
                    "\n\nNumber of Fights: " + txtbxNumFights.Text + "\nArrangement Used: "+arrangement +
                    "\n\nEnemy's arrangement: "+printArrangement()+
                    "\n\nWins: " + wins + "\t\t\tLosses: " + losses +
                    "\n\nWin Percentage: "+(wins/double.Parse(txtbxNumFights.Text)).ToString("P1")+
                    "\n\nAverage Rounds: " + getData(rounds, "avg")+
                    "\nMin Rounds: " + getData(rounds, "min") + "\t\t1st quartile: "+ getData(rounds, "firstQuartile") +"\n3rd quartile: " + getData(rounds, "thirdQuartile") + "\t\tMax Rounds: " +getData(rounds, "max")+
                    "\nGold Gained: "+gold;

            MessageBox.Show(results);
        }

        private void resetCharacterFaces()
        {
            faces = new int[6];
            faces[5] = Int32.Parse(txtbxMaxPoints.Text);
        }

        private int enemyTurn(int numRounds)
        {
            int enemyRoll = enemyFaces[rand.Next(0, 5)];
            return enemyRoll;
        }

        private int playerTurn(int numRounds)
        {
            int scheduleCounter = numRounds % schedulePoints;
            if (schedule[scheduleCounter] == 1)
            {
                 // for (int i = 0; i < scheduleCounter; i++)
                 // {
                        changeArrangement(arrangement, numRounds);
                 // }
            }
            int playerRoll = faces[rand.Next(0, 5)];
            return playerRoll;

        }

        private void changeArrangement(string arrangement, int numRounds)
        {
            switch (arrangement)
            {
                case "Random": 
                    int adder = rand.Next(0, 5);
                    int subtracter = rand.Next(0, 5);
                    while (faces[subtracter] == 0)
                    {
                        subtracter = rand.Next(0, 6);
                    }
                    faces[adder]+=1;
                    faces[subtracter]-=1;
                    break;

                case "Even":
                    maxFaceValue  = Math.Floor(decimal.Parse(txtbxMaxPoints.Text) / 6);
                    if (faces[numRounds % 5] < maxFaceValue)
                    {
                        faces[numRounds % 5]++;
                        faces[5]--;
                    }
                    break;

                case "Halves":
                    faces = halves(faces, 4, 5, Int32.Parse(txtbxMaxPoints.Text));
                    break;

                case "Match Highest":
                    break;

                case "Median+":
                    int medianPlus = 0;
                    int[] enemyArrangement = new int[6];
                    for (int i = 0; i < 6; i++)
                    {
                        enemyArrangement[i] = enemyFaces[i];
                    }
                    Array.Sort(enemyArrangement);
                    if (enemyArrangement.Length % 2 == 0)
                    {
                        int halfway = enemyArrangement.Length / 2;
                        medianPlus = ((enemyArrangement[halfway] + enemyArrangement[halfway - 1]) / 2) + 1;
                    }
                    else
                    {
                        medianPlus = enemyArrangement[(enemyArrangement.Length - 1) / 2] + 1;
                    }

                    if (faces[0] < medianPlus)
                    {
                        faces[findMaxFace(faces)]--;
                        faces[0]++;
                    }
                    else if (faces[1] < medianPlus)
                    {
                        faces[findMaxFace(faces)]--;
                        faces[1]++;
                    }
                    else if (faces[2] < medianPlus)
                    {
                        faces[findMaxFace(faces)]--;
                        faces[2]++;
                    }
                    else if (faces[3] < medianPlus)
                    {
                        faces[findMaxFace(faces)]--;
                        faces[3]++;
                    }
                    else if (faces[4] < medianPlus)
                    {
                        faces[findMaxFace(faces)]--;
                        faces[4]++;
                    } 
                    else if (faces[5] < medianPlus)
                    {
                        faces[findMaxFace(faces)]--;
                        faces[5]++;
                    }
                    break;

                default:
                    MessageBox.Show("Broken!");
                    break;
            }
            
            if (chkbxShowSteps.Checked==true)
            {
                MessageBox.Show("P: " + faces[0] + ", " + faces[1] + ", " + faces[2] + ", " + faces[3] + ", " + faces[4] + ", " + faces[5]
               + "\nE: " + enemyFaces[0] + ", " + enemyFaces[1] + ", " + enemyFaces[2] + ", " + enemyFaces[3] + ", " + enemyFaces[4] + ", " + enemyFaces[5]);
            }
            
        }

        private int[] halves(int[] array, int posA, int posB, int max)
        {
            bool canExit = false;
            while (canExit == false)
            {
                if ((array[posB] == (max/2)))
                {
                    posA--;
                    max = array[posB];
                    posB--;
                    if (posA == -1)
                    {
                        canExit = true;
                    }
                }
                else if ((array[posB] - array[posA]) == 0 || (array[posB] - array[posA]) == 1)
                {
                    posA--;
                    max = array[posB];
                    posB--;
                    if (posA == -1)
                    {
                        canExit = true;
                    }
                }
                else
                {
                    array[posA] += 1;
                    array[posB] -= 1;
                    canExit = true;
                }
            }
            return array;
        }

        private int[] preArrange(string arrangement, int max)
        {
            int[] sorted = new int[6];
            switch (arrangement)
            {
                case "Random":
                    for (int i = 0; i < max; i++)
                    {
                        int position = rand.Next(0, 5);
                        sorted[position]++;
                    }
                    break;

                case "Even":
                    for (int i = 0; i < max; i++)
                    {
                        sorted[i % 6]++;
                    }
                    break;

                case "Halves":
                    sorted[0] = max / 2;
                    sorted[1] = sorted[0] / 2;
                    sorted[2] = sorted[1] / 2;
                    sorted[3] = sorted[2] / 2;
                    sorted[4] = sorted[3] / 2;
                    sorted[5] = sorted[4] / 2;
                    break;

                case "Median+":
                    int medianPlus = 0;
                    int[] enemyArrangement = new int[6];
                    for (int i = 0; i < 6; i++)
                    {
                        enemyArrangement[i] = enemyFaces[i];
                    }
                    Array.Sort(enemyArrangement);
                    if (enemyArrangement.Length % 2 == 0)
                    {
                        int halfway = enemyArrangement.Length / 2;
                        medianPlus = ((enemyArrangement[halfway] + enemyArrangement[halfway - 1]) / 2) + 1;
                    }
                    else
                    {
                        medianPlus = enemyArrangement[(enemyArrangement.Length - 1) / 2] + 1;
                    }
                    break;

            }

            return sorted;
        }

        private int findMaxFace(int[] array)
        {
            int max = 0;
            int position = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= max)
                {
                    max = array[i];
                    position = i;
                }
            }
            return position;
        }

        private int findMinFace(int[] array)
        {
            int min = 0;
            int position = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= min)
                {
                    min = array[i];
                    position = i;
                }
            }
            return position;
        }

        private string whoDied()
        {
            if (player.CurrentHp <= 0)
            {
                return "player";
            }
            else if (enemy.CurrentHp <= 0)
            {
                return "enemy";
            }
            else
            {
                return null;
            }
        }

        private void whoHit(int playerRoll, int enemyRoll)
        {
            if (playerRoll > enemyRoll)
            {
                enemy.CurrentHp -= player.Attack;
            }
            else if (enemyRoll > playerRoll)
            {
                player.CurrentHp -= enemy.Attack;
            }
            else
            {
                //Nothing Happens
            }
            
            if (chkbxShowSteps.Checked == true)
            {
                 MessageBox.Show("Player: "+playerRoll+ "\tEnemy: "+enemyRoll+
                 "\n->  "+player.CurrentHp+"/"+player.MaxHp+"\t->  "+enemy.CurrentHp+"/"+enemy.MaxHp);
            } 
            
        }

        private int getData(List<int> rounds, string measure)
        {
            int data = 0;
            int sum = 0;
            int max = 0;
            int min = 999999999;
            int[] arr = new int[6];
            switch (measure)
            {
                case "avg":
                    for (int i = 0; i < rounds.Count; i++)
                    {
                        sum += rounds[i];
                    }
                    data = sum / rounds.Count;
                    break;

                case "max":
                    for (int i = 0; i < rounds.Count; i++)
                    {
                        if (rounds[i] > max)
                        {
                            max = rounds[i];
                        }
                    }
                    data = max;
                    break;

                case "min":
                    for (int i = 0; i < rounds.Count; i++)
                    {
                        if (rounds[i] < min)
                        {
                            min = rounds[i];
                        }
                    }
                    data = min;
                    break;

                case "firstQuartile":
                    arr = new int[6];
                    rounds.Sort();
                    int firstQuartile = (rounds.Count / 4);
                    data = rounds[firstQuartile];
                    break;

                case "thirdQuartile":
                    rounds.Sort();
                    int thirdQuartile = ((rounds.Count * 3) / 4);
                    data = rounds[thirdQuartile];
                    break;
            }
            return data;
        }

        private string printArrangement()
        {
            string enemyArrangement = "";
            for (int i = 0; i < 6; i++)
            {
                enemyArrangement += enemyFaces[i] + " ";
            }
            return enemyArrangement;
        }
    }
}

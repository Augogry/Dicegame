using System;
using System.Windows.Forms;

namespace DiceGame
{
    //This class receives user input from the user to begin the game
    public partial class DiceGameLaunch : Form
    {
        private int numPlayers;
        private string[] gameInfo;

        inputNameForm inf;
        public DiceGameLaunch()
        {
            InitializeComponent();
        }

        private void DiceGameLaunch_Load(object sender, EventArgs e)
        {
            gameInfo = new string[5];
            btnTwoP.Enabled = false;
        }

        private void btnOneP_Click(object sender, EventArgs e)
        {
            inf = new inputNameForm();
            this.Hide();
            numPlayers = 1;
            inf.ShowDialog(1);
            gameInfo[0] = numPlayers.ToString();
            gameInfo[1] = inf.getPlayer();
            gameInfo[2] = inf.getAdversary();
            gameInfo[3] = inf.getDifficulty();
            gameInfo[4] = inf.getItem();
        }

        private void btnTwoP_Click(object sender, EventArgs e)
        {
            if (btnTwoP.Enabled == false)
            {

            }
            else
            {
                inf = new inputNameForm();
                this.Hide();
                numPlayers = 2;
                inf.ShowDialog(2);
                gameInfo[0] = numPlayers.ToString();
                gameInfo[1] = inf.getPlayer();
                gameInfo[2] = inf.getAdversary();
                gameInfo[3] = inf.getDifficulty();
            }
            
        }

        public string[] getGameInfo()
        {           
            return gameInfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simulacrum sc = new Simulacrum();
            sc.ShowDialog();
        }
    }
}

using System;
using System.Windows.Forms;

namespace DiceGame
{
    class DiceGame
    {
        private string gameMode;        
        private Character player,adversary;
        private string playerName, adversaryName;
        private Random rand = new Random();
        private int difficulty, currentLevel = 1;

        public void launch()
        {//Launches DicegameLaunch, then initializes character to begin game
            DiceGameLaunch dgl = new DiceGameLaunch();
            dgl.ShowDialog();
            string[] info = dgl.getGameInfo();
            gameMode = info[0];
            playerName = info[1];
            adversaryName = info[2];
            difficulty = Int32.Parse(info[3]);
            player = new Character(playerName);
            //MessageBox.Show(info[4]);
            player.Equip(info[4]);

            if (gameMode == "1")//Single player mode
            {
                //MessageBox.Show("Prepare your descent, adventurer");
                while (currentLevel < 11)//Game will run for ten levels/dungeons
                {
                    launchDungeon();
                    MessageBox.Show("Completed " + currentLevel);
                }
            }
            else//Two player mode
            {
                launchTwoPlayers();
            }

        } 

        public void launchDungeon()
        {
            //Game initiated here
            DungeonForm dgf = new DungeonForm();
            dgf.ShowDialog(player, difficulty, currentLevel);
            MessageBox.Show("You have conquered this dungeon! Onward adventurer!");
            player.MaxHp += 10;
            player.Attack += 5;
            player.CurrentHp = player.MaxHp;
            difficulty *= (difficulty/4);
            currentLevel++;
        }
        
        public void launchTwoPlayers()
        {
            adversary = new Character(adversaryName);
            TwoPlayers tp = new TwoPlayers();
            tp.ShowDialog(player, adversary);
        }
    }
}

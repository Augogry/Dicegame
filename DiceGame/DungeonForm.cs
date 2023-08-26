using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class DungeonForm : Form
    {
        Character player, monster;
        Cell current;
        string currentCellName;
        int oldCol, oldRow;
        private List<Cell> map;
        Random rng = new Random();
        int totalMonsters = 9;
        int difficulty, mp = 0, increase = 0;//Initial difficulty, Max Points and increase variable
        int numDung;

        public DungeonForm()
        {
            InitializeComponent();
        }

        public void ShowDialog(Character plyr, int diff, int numDungeons/*, String[] stats*/)
        {
            player = new Character(plyr);
            difficulty = diff;
            numDung = numDungeons;
            ShowDialog();
        }

        private void DungeonForm_Load(object sender, EventArgs e)
        {
            addButtons();
            loadMap();
            current = map[0];
            //monster.MaxPoints = rng.Next(player.MaxPoints+3, player.MaxPoint)
            selectCell("1_5");
            //printMap();
        }
        private void selectCell(string cellName)
        {
            foreach (Cell c in map)
            {
                if (cellName.Equals(c.CellLocation))
                {
                    current = c;
                }
            }
            current.CellButton.BackColor = Color.Green;
            loadCellInfo();
            if (cellName.Equals("5_1"))//Checking for final cell
            {
                //Make a boss
                MessageBox.Show("Boss Fight! (To be added...)");
                exitGame();
                Application.Run();
            }
            else
            {
                if (current.HasBeenEntered == true)
                {
                    
                }
                else
                {
                    if (current.HasMonster == true)
                    {
                        createMonster(current);
                        fight();
                        increase = player.CurrentHp / 10;
                        if (increase > 4)
                        {
                            increase = 4;
                        }
                        mp += increase;
                        totalMonsters -= 1;
                    }
                    else
                    {
                        if (current.CellLocation.Equals("1_5"))
                        {
                            
                        }
                        else
                        { 
                            MessageBox.Show("This room is empty!");
                        }
                    }
                }
            }
        }
        private void getCellinfo()
        {
            currentCellName = current.CellLocation;
            oldCol = Int32.Parse((currentCellName.ElementAt(0)).ToString());
            oldRow = Int32.Parse((currentCellName.ElementAt(2)).ToString());
        }
        private void goUp()
        {
            getCellinfo();
            MessageBox.Show("I can hear you: " + currentCellName);
            int newRow = 0;
            if (oldRow == 1)
            {
                newRow = 1;
            }
            else
            {
                newRow = oldRow - 1;
            }
            current.CellButton.BackColor = Color.Gray;
            string newCellPosition = oldCol + "_" + newRow;
            selectCell(newCellPosition);
        }
        private void goDown()
        {
            getCellinfo();
            int newRow = 0;
            if (oldRow == 5)
            {
                newRow = 5;
            }
            else
            {
                newRow = oldRow + 1;
            }
            current.CellButton.BackColor = Color.Gray;
            string newCellPosition = oldCol + "_" + newRow;
            selectCell(newCellPosition);
        }
        private void goLeft()
        {
            getCellinfo();
            int newCol = 0;
            if (oldCol == 1)
            {
                newCol = 1;
            }
            else
            {
                newCol = oldCol - 1;
            }
            current.CellButton.BackColor = Color.Gray;
            string newCellPosition = newCol + "_" + oldRow;
            selectCell(newCellPosition);
        }
        private void goRight()
        {
            getCellinfo();
            int newCol = 0;
            if (oldCol == 5)
            {
                newCol = 5;
            }
            else
            {
                newCol = oldCol + 1;
            }
            current.CellButton.BackColor = Color.Gray;
            string newCellPosition = newCol + "_" + oldRow;
            selectCell(newCellPosition);
        }
        private void fight()
        {
            MessageBox.Show("There is a " + monster.Name + " in this cell. Prepare for battle");
            OnePlayer fight = new OnePlayer();
            fight.ShowDialog(player, monster);
            player = new Character(fight.getPlayer());
            exitGame();
        }
        private void arrowKeyControls(object sender, KeyEventArgs e)
        {
            MessageBox.Show("I can hear you! " + currentCellName);
            switch (e.KeyCode)
            {
                case Keys.Up:
                    goUp();
                    break;
                case Keys.Down:
                    goDown();
                    break;
                case Keys.Left:
                    goLeft();
                    break;
                case Keys.Right:
                    goRight();
                    break;
            }
            MessageBox.Show("Confirmed" + currentCellName);
        }

        private void Clicked(object sender, EventArgs e)
        {
            getCellinfo();
            string newCellPosition = "";
            string newCell = (sender as Button).Name;
            //MessageBox.Show(newCell);
            int newRow = Int32.Parse(newCell.ElementAt(5).ToString());
            int newCol = Int32.Parse(newCell.ElementAt(3).ToString());
            if ((newRow == (oldRow - 1) && newCol == oldCol)|| (newRow == (oldRow + 1) && newCol == oldCol))
            {
                //going up or down
                current.CellButton.BackColor = Color.Gray;
                newCellPosition = oldCol + "_" + newRow;
                selectCell(newCellPosition);
            }
            else if ((newRow == oldRow && newCol == (oldCol - 1))|| (newRow == oldRow && newCol == (oldCol + 1)))
            {
                //going left or right
                current.CellButton.BackColor = Color.Gray;
                newCellPosition = newCol + "_" + oldRow;
                selectCell(newCellPosition);
            }
            else
            { 
                //invalid cell selected
            }

        }
        private void loadMap()
        {
            string cellName = "";
            map = new List<Cell>();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    cellName = i + "_" + j;
                    try
                    {
                        map.Add(new Cell(cellName, findButton(cellName)));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            distributeWeights();
        }
        private void distributeWeights()
        {
            int[] cellWeights = new int[25] { 3, 3, 5, 9, 0, 3, 3, 4, 5, 9, 3, 3, 5, 4, 5, 6, 5, 3, 3, 3, 0, 6, 3, 3, 3 };
            int counter = 0;
            foreach (Cell c in map)
            {
                c.MonsterWeight = cellWeights[counter];
                counter++;
            }
            int numMonsters = totalMonsters;
            while (numMonsters > 0)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (map[i].HasMonster == false)
                    {
                        int randomWeight = rng.Next(0, 99);
                        if (randomWeight <= map[i].MonsterWeight && randomWeight != 0 && numMonsters != 0)
                        {
                            map[i].HasMonster = true;
                            numMonsters--;
                        }
                    }
                }
            }
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void DungeonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(-1);
        }

        private void loadCellInfo()
        {
            lblMonsterType.Text = "Monster Type: " + current.MonsterType;
            lblMonsterChance.Text = "Monsters Chance: " + current.MonsterWeight;
        }
        private Button findButton(string buttonName)
        {
            Button foundButton = new Button();
            foreach (Button btn in buttonArray)
            {
                if (buttonName.Equals(btn.Name.Substring(3)))
                {
                    foundButton = btn;
                }
            }
            return foundButton;
        }
        private void createMonster(Cell cell)
        {
            monster = new Character(cell.MonsterType);
            if (player.MaxPoints == 10)
            {
                monster.MaxPoints = difficulty;
            }
            else
            {
                monster.MaxPoints = difficulty + increase + (rng.Next(-1, 1));
                monster.MaxHp = (int)(player.MaxHp * 1.3);
                monster.CurrentHp = monster.MaxHp;
                monster.Attack = monster.Attack + (int)(monster.Attack * 0.2);
            }

        }
        private void exitGame()
        {
            if (player.CurrentHp <= 0)
            {
                MessageBox.Show("Alas adventurer, your journey has come to an end. Farewell." +
                    "\nYou survived "+ (numDung - 1) +" dungeons.");
                Environment.Exit(-1);
            }
        }

    }
}

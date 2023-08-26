using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mapping
{

    public partial class MappingForm : Form
    {
        Button currentCell;
  
        string currentCellName;
        int oldCol;
        int oldRow;
        private List<Cell> map;

        public MappingForm()
        {
            InitializeComponent();
        }

        private void MappingForm_Load(object sender, EventArgs e)
        {
            addButtons();
            loadMap();
            selectCell("1_5");
            
        }
        private void selectCell(string cellName)
        {
            currentCell = btn1_5;
            foreach (Button btn in buttonArray)
            {
                if (cellName.Equals(btn.Name))
                {
                    currentCell = btn;
                }
            }
            currentCell.BackColor = Color.Green;
        }
        private void getCellinfo()
        {
            currentCellName = currentCell.Name;
            oldCol = Int32.Parse((currentCellName.ElementAt(3)).ToString());
            oldRow = Int32.Parse((currentCellName.ElementAt(5)).ToString());
        }
        private void goUp()
        {
            getCellinfo();
            int newRow = 0;
            if (oldRow == 1)
            {
                newRow = 1;
            }
            else
            {
                newRow = oldRow - 1;
            }
            currentCell.BackColor = Color.Gray;
            string newCellPosition = "btn" + oldCol + "_" + newRow;
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
            currentCell.BackColor = Color.Gray;
            string newCellPosition = "btn" + oldCol + "_" + newRow;
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
            currentCell.BackColor = Color.Gray;
            string newCellPosition = "btn" + newCol + "_" + oldRow;
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
            currentCell.BackColor = Color.Gray;
            string newCellPosition = "btn" + newCol + "_" + oldRow;
            selectCell(newCellPosition);
        }
        private void arrowKeyControls(object sender, KeyEventArgs e)
        {
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
        }
        private void getConnected()
        {

        }
        private void clearConnected()
        {

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
        }
        private void loadCellInfo()
        {
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

        private void showConnected()
        {
            foreach (Button btn in buttonArray)
            {
                if(!(btn.Name.Equals(currentCellName)))
                {
                    btn.BackColor = Color.Gray;
                }


            }
        }

        private Button[] connected(Button currentButton)
        {
            return;
        }


    }
}
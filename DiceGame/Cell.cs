using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    class Cell
    {
        private string cellLocation;
        private int monsterWeight;
        private bool hasBeenEntered;
        private bool hasMonster;
        private string roomStatus;
        private int itemPercentage;
        private Button cellButton;
        private string monsterType;

        public string CellLocation { get => cellLocation; set => cellLocation = value; }
        public bool HasBeenEntered { get => hasBeenEntered; set => hasBeenEntered = value; }
        public string RoomStatus { get => roomStatus; set => roomStatus = value; }
        public int ItemPercentage { get => itemPercentage; set => itemPercentage = value; }
        public Button CellButton { get => cellButton; set => cellButton = value; }
        public string MonsterType { get => monsterType; set => monsterType = value; }
        public int MonsterWeight { get => monsterWeight; set => monsterWeight = value; }
        public bool HasMonster { get => hasMonster; set => hasMonster = value; }

        public Cell()
        {
            CellLocation = "";
            MonsterWeight = 0;
            ItemPercentage = 0;
            HasBeenEntered = false;
            RoomStatus = "normal";
            HasMonster = false;
        }

        public Cell(string name, Button btn)
        {
            CellLocation = name;
            MonsterWeight = 0;
            ItemPercentage = 0;
            HasBeenEntered = false;
            RoomStatus = "normal";
            CellButton = btn;
            HasMonster = false;
            switch (Int16.Parse(CellLocation.ElementAt(0).ToString()))
            {
                case 1:
                    MonsterType = "Ghost";
                    break;
                case 2:
                    MonsterType = "Troll";
                    break;
                case 3:
                    MonsterType = "Horc";
                    break;
                case 4:
                    MonsterType = "Grunt";
                    break;
                case 5:
                    MonsterType = "Barbarian";
                    break;
                default:
                    break;
            }
        }

        public Cell(string name, int mWeight, int iPercent, bool entered, string status)
        {
            CellLocation = name;
            MonsterWeight = mWeight;
            ItemPercentage = iPercent;
            HasBeenEntered = entered;
            RoomStatus = status;
            HasMonster = false;
            switch (Int16.Parse(CellLocation.ElementAt(2).ToString()))
            {
                case 1:
                    MonsterType = "Ghost";
                    break;
                case 2:
                    MonsterType = "Troll";
                    break;
                case 3:
                    MonsterType = "Horc";
                    break;
                case 4:
                    MonsterType = "Grunt";
                    break;
                case 5:
                    MonsterType = "Barbarian";
                    break;
                default:
                    break;
            }
        }

        public Cell(Cell copy)
        {
            this.cellLocation = copy.cellLocation;
            this.MonsterWeight = copy.MonsterWeight;
            this.ItemPercentage = copy.ItemPercentage;
            this.HasBeenEntered = copy.HasBeenEntered;
            this.RoomStatus = copy.RoomStatus;
            this.CellButton = copy.CellButton;
            this.HasMonster = copy.HasMonster;
        }

        public void clearCell()
        {
            this.HasMonster = false;
            this.RoomStatus = "Empty";

        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiceGame
{
    public class Character
    {
        private string name;
        private int maxHp;
        private int currentHp;
        private int attack;
        private int maxPoints;
        private List<int> schedule = new List<int> { 0, 0, 0};
        private int maxValue;
        private int gold;
        Random rand = new Random();
        private List<Item> inventory = new List<Item>();
        private Item equipped;

        public int Gold
        {
            get
            {
                return gold;
            }

            set
            {
                gold = value;
                if (gold < 0)
                {
                    gold = 0;
                }
            }
        }

        public int MaxHp
        {
            get
            {
                return maxHp;
            }

            set
            {
                maxHp = value;
            }
        }

        public int CurrentHp
        {
            get
            {
                return currentHp;
            }

            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                currentHp = value;
            }
        }

        public int Attack
        {
            get
            {
                return attack;
            }

            set
            {
                attack = value;
            }
        }

        public int MaxPoints
        {
            get
            {
                return maxPoints;
            }

            set
            {
                maxPoints = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public List<int> Schedule
        {
            get
            {
                return schedule;
            }

            set
            {
                schedule = value;
            }
        }

        public Item Equipped { get => equipped; set => equipped = value; }

        public Character()
        {
            Name = "";
            MaxHp = 100;
            CurrentHp = 100;
            Attack = 5;
            maxValue = 2;
            MaxPoints = 10;
            createSchedule();
            Equipped = new Item();
            Gold = 100;
        }    
        
        public Character(string n)
        {
            Name = n;
            MaxHp = 100;
            CurrentHp = 100;
            Attack = 5;
            MaxPoints = 10;
            maxValue = 2;
            createSchedule();
            Equipped = new Item();
            Gold = 100;
        }

        public Character(Character copy)
        {
            this.name = copy.name;
            this.maxHp = copy.maxHp;
            this.currentHp = copy.currentHp;
            this.attack = copy.attack;
            this.maxPoints = copy.maxPoints;
            this.maxValue = copy.maxValue;
            this.schedule = copy.schedule;
            this.equipped = copy.equipped;
            this.gold = copy.gold;
        }

        private void createSchedule()
        {
            int maxValue = 2;
            for (int i = 0; i < 3; i++)
            {
                int chance = rand.Next(1, 100);
                if (chance < 51)
                {
                    if (maxValue > 0 && Schedule[i]==0)
                    {
                        Schedule[i] += 1;
                        maxValue--;
                    }           
                }
                if (i == 2 && maxValue > 0)
                {
                    i = 0;
                }
            }
        }

        public void addToInventory(Item item)
        {
            inventory.Add(item);
        }

        public void Equip(string item)
        {
            Equipped = new Item(item);
        }
    }
}


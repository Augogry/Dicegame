using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Item
    {
        string itemName;
        string type;
        string special;
        double atkMultiplier;
        double critMultiplier;
        double critChance;
        int armorBuff;
        int healthBuff;
        int cooldown;
        private string specialID;
        public string ItemName { get => itemName; set => itemName = value; }
        public string Type { get => type; set => type = value; }
        public string Special { get => special; set => special = value; }
        public double AtkMultiplier { get => atkMultiplier; set => atkMultiplier = value; }
        public double CritMultiplier { get => critMultiplier; set => critMultiplier = value; }
        public double CritChance { get => critChance; set => critChance = value; }
        public int ArmorBuff { get => armorBuff; set => armorBuff = value; }
        public int HealthBuff { get => healthBuff; set => healthBuff = value; }
        public int Cooldown { get => cooldown; private set => cooldown = value; }
        public string SpecialID { get => specialID; set => specialID = value; }

        public Item()
        {
            basic();
        }

        public Item(string name)
        {
            createItem(name);
        }

        public Item(Item copy)
        {
            this.ItemName = copy.ItemName;
            this.Type = copy.Type;
            this.Special = copy.Special;
            this.AtkMultiplier = copy.AtkMultiplier;
            this.CritMultiplier = copy.CritMultiplier;
            this.CritChance = copy.CritChance;
            this.ArmorBuff = copy.ArmorBuff;
            this.HealthBuff = copy.HealthBuff;
            this.Cooldown = copy.Cooldown;
        }

        private void createItem(string name)
        {
            basic();
            switch (name.ToLower())
            {
                case "sword":
                    ItemName = "Sword";
                    Type = "blade";
                    Special = "";
                    SpecialID = "B1";
                    AtkMultiplier = 1.10;
                    CritMultiplier = 1.50;
                    CritChance = 5;
                    Cooldown = 1;
                    break;

                case "dagger":
                    ItemName = "Dagger";
                    Type = "blade";
                    Special = "For one round, add 1 to one side.\nCooldown: 3 rounds";
                    SpecialID = "B2";
                    AtkMultiplier = 1.10;
                    CritMultiplier = 1.50;
                    CritChance = 5;
                    Cooldown = 3;
                    break;

                case "shortsword":
                    ItemName = "Shortsword";
                    Type = "blade";
                    Special = "For two rounds, add 2 to two sides.\nCooldown: 5 rounds";
                    SpecialID = "B3";
                    AtkMultiplier = 1.10;
                    CritMultiplier = 1.50;
                    CritChance = 5;
                    Cooldown = 5;
                    break;

                case "staff":
                    ItemName = "Staff";
                    Type = "Staff";
                    Special = "For two rounds, add 1 to one side and turn one side into a *.\nCooldown: 7 rounds";
                    SpecialID = "S1";
                    AtkMultiplier = 1.30;
                    CritMultiplier = 1.75;
                    CritChance = 10;
                    Cooldown = 7;
                    break;

                case "club":
                    ItemName = "Club";
                    Type = "club";
                    Special = "For one round, add 2 to one side.\nCooldown: 4 rounds";
                    SpecialID = "C1";
                    AtkMultiplier = 1.50;
                    CritMultiplier = 1.75;
                    CritChance = 8;
                    Cooldown = 7;
                    break;

                default:
                    itemName = "fists";
                    break;
            }
        }

        private void basic()
        {
            this.ItemName = "Fist";
            this.Type = "";
            this.Special = "";
            this.AtkMultiplier = 0;
            this.CritMultiplier = 0;
            this.CritChance = 0;
            this.ArmorBuff = 0;
            this.HealthBuff = 0;
            this.Cooldown = 0;
        }
    }
}

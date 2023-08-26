using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class BasicCells
    {
        private int value;
        private List<BasicCells> connected;

        public BasicCells(int val)
        {
            Value = val;
            connected = new List<BasicCells>();
        }

        public int Value { get => value; set => this.value = value; }

        public void connectTo(BasicCells cell)
        {
            connected.Add(cell);
        }

        public string getConnected()
        {
            return connected.ToString();
        }
    }
}

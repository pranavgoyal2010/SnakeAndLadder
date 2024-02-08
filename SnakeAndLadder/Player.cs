using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class Player
    {
        private int playerPosition;
        private int playerNumber;
            
        public Player(int playerNumber)
        {
            this.playerPosition = 0;
            this.playerNumber = playerNumber;            
        }

        /*public int PlayerPosition
        {
            get{ return this.playerPosition; }
            set { this.playerPosition = value; }
        }*/
        public int PlayerPosition { get; set; }
        public override string ToString()
        {
            return "Player " + this.playerNumber;
        }

    }
}

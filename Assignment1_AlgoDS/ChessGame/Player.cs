using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame
{
    class Player
    {
        private string currentPlayer;
        // initialise new player
        public Player(string player)
        {
            this.currentPlayer = player;
        }

        // Returns current player
        public string CurrentPlayer()
        {
            return currentPlayer;
        }

        // Change player turn
        public void ChangePlayer()
        {
            if (this.currentPlayer == "white")
            {
                this.currentPlayer = "black";
            }
            else
            {
                this.currentPlayer = "white";
            }
        }
    }
}

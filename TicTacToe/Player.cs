using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace TicTacToe
{
    public class Player
    {
        private string Name;
        private int PlayerNumber;
        private string Symbol;

        public Player(int playerNumber, string symbol)
        {
            PlayerNumber = playerNumber;
            Symbol = symbol;
        }
        public string GetName()
        {
            return Name;
        }

        public void SetName()
        {
            Name = Console.ReadLine();
        }

    }
}

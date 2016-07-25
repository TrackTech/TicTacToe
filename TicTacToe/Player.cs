using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public enum PlayerType { Human, Computer }

    public struct Player
    {
        
        #region Fields

        public PlayerType type;
        public char symbol;

        #endregion

        #region Constructor

        public Player(PlayerType type, Char symbol)
        {
            this.type = type;
            this.symbol = symbol;
        }

        #endregion
    }
}

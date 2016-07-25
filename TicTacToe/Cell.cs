using System;

namespace TicTacToe
{
    public class Cell
    {
        #region Fields

        private int row;
        private int col;
        private bool isOccupied;
        private Player player;

        #endregion

        #region Properties

        public int Row
        {
            get { return row; }
            set { row = value; }
        }
      
        public int Col
        {
            get { return col; }
            set { col = value; }
        }
        
        public bool IsOccupied
        {
            get { return isOccupied; }
            set { isOccupied = value; }
        }
        
        public Player Player
        {
            get { return player; }
            set { player = value; }
        }

        public String Coordinates
        {
            get { return "[" + row.ToString() + "," + col.ToString() + "]"; }
        }

        public bool IsOnFirstDiagnol 
        {
            get { return row == col; }
        }

        public bool IsOnSecondDiagnol 
        {
            get { return (row+col)==2; }
        }

        #endregion
    }
}

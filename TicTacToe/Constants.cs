using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class Constants
    {
        #region Constants

        public const int MATRIX_ROWS = 3;
        public const int MATRIX_COLUMNS = 3;
        public static readonly char[] possibleSymbol = new char[] { 'X', 'x', 'o', 'O' };
        public static readonly char[] possibleCoordinateVal = new char[] { '0', '1', '2' };

        #endregion

    }
}

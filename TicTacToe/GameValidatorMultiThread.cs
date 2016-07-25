using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    class GameValidatorMultiThread
    {        
        private class InputValue
        {
            internal Cell[] currentMatrix;
            internal Cell lastMove;            
        }
        #region Private Methods

        #region Game Status
        private static void GameOver(Cell lastMove)
        {
            Console.WriteLine("-------Game Over------");
            if (lastMove.Player.type == PlayerType.Computer)
            {
                Console.WriteLine("Computer won");
            }
            else
            {
                Console.WriteLine("You are the winner");
            }
        }

        private static void GameDraw()
        {
            Console.WriteLine("----------Game Over---------");
            Console.WriteLine("--------ITS A DRAW----------");
        }

        private static bool IsLastMove(int moves)
        {
            return moves == 8;
        }

        #endregion

        #region Validators
        private static bool ValidateRows(Cell[] matrix, Cell lastMove)
        {
            
            var rows = Array.FindAll<Cell>(matrix, val => val.IsOccupied == true && val.Row == lastMove.Row && val.Player.symbol == lastMove.Player.symbol);

            if (rows.Length == 3)
                return true;
            return false;
        }

        private static bool ValidateCols(Cell[] matrix, Cell lastMove)
        {
            var cols = Array.FindAll<Cell>(matrix, val => val.IsOccupied == true && val.Col == lastMove.Col && val.Player.symbol == lastMove.Player.symbol);

            if (cols.Length == 3)
                return true;
            return false;
        }

        private static bool ValidateDiag(Cell[] matrix, Cell lastMove)
        {
            Cell[] cell;
            if (lastMove.IsOnFirstDiagnol || lastMove.IsOnSecondDiagnol)
            {
                if (lastMove.IsOnFirstDiagnol)
                {
                    cell = Array.FindAll<Cell>(matrix, val => val.IsOccupied == true && val.IsOnFirstDiagnol == true && val.Player.symbol == lastMove.Player.symbol);
                }
                else
                {
                    cell = Array.FindAll<Cell>(matrix, val => val.IsOccupied == true && val.IsOnSecondDiagnol == true && val.Player.symbol == lastMove.Player.symbol);
                }
                if (cell.Length == 3)
                    return true;
            }
            return false;
        }

        #endregion

        #endregion

        public static bool ValidateWon(Cell[] matrix, Cell lastMove, int moves)
        {

            if (moves < 4)
                return false;
            ThreadPool


            return false;
        }
    }
}

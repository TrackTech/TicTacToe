using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
       
    public class Game
    {
        #region Member variables

        private Cell[] matrix;
        private Player currentPlayer;
        private Player human;
        private Player computer;
        private int moves;
        private Random rnd;

        #endregion

        #region Constructor

        public Game(Player human, Player computer,PlayerType firstMove)
        {
            this.human = human;
            this.computer = computer;           
            initMatrix();            
            currentPlayer = (firstMove==PlayerType.Computer)?computer:human;
            rnd = new Random();
        }

        #endregion

        #region Private Methods

        private void initMatrix()
        {
            matrix = new Cell[9];
            for (int i = 0; i < Constants.MATRIX_ROWS; i++)
            {
                for (int j = 0; j < Constants.MATRIX_COLUMNS; j++)
                {
                    matrix[(i * Constants.MATRIX_ROWS) + j] = new Cell() { Row = i, Col = j };
                }
            }
        }

        private Cell GetComputerMove()
        {
            var avai = AvailableCells();
            int index = GetRandomIndex(avai.Length);            
            avai[index].Player = computer;
            avai[index].IsOccupied = true;
            Console.WriteLine("Computer picked " + avai[index].Coordinates);
            Util.PrintMatrix(matrix,Constants.MATRIX_ROWS,Constants.MATRIX_COLUMNS);
            return avai[index];
        }

        private int GetRandomIndex(int arrLength)
        {
            if (arrLength > 1)
                return rnd.Next(0, arrLength - 1);
            else
                return 0;
        }

        private Cell GetHumanMove()
        {
            var avai = AvailableCells();
            Util.PrintAvailable(avai);
            int r, c;
            while (true)
            {
                r = Util.GetXValue(Constants.possibleCoordinateVal);
                c = Util.GetYValue(Constants.possibleCoordinateVal);
                if (Array.Find<Cell>(avai, val => val.Row == r && val.Col == c)==null)
                {
                    Console.WriteLine("---Invalid Selection---");
                }
                else
                { break; }
            }
            Cell humanChoice = Array.Find<Cell>(avai,value => value.Row == r && value.Col == c);
            humanChoice.Player = human;
            humanChoice.IsOccupied = true;
            return humanChoice;
        }               

        private void SwitchTurn(){
            if(currentPlayer.type == PlayerType.Computer)
                currentPlayer = human;
            else
                currentPlayer = computer;
        }

        private Cell[] AvailableCells()
        {
            return Array.FindAll<Cell>(matrix, value => value.IsOccupied == false);
        }

        #endregion

        #region Public Method

        public void Begin()
        {
            while (true)
            {
                try
                {
                    Cell move;
                    if (currentPlayer.type == PlayerType.Computer)
                    {
                        move = GetComputerMove();
                    }
                    else
                    {
                        move = GetHumanMove();
                    }
                    if (GameValidator.ValidateWon(matrix, move, moves)) return;
                    if (GameValidator.ValidateDraw(moves)) return;

                    SwitchTurn();
                    moves++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Program has terminated with an excemption[Hit enter]:" + ex.Message);
                    Console.ReadLine();
                    return;
                }

            }
        }

        #endregion
    }
}

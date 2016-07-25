using System;

namespace TicTacToe
{
    class Program
    {
        #region Main Method

        static void Main(string[] args)
        {            
            char ch= Util.GetPlayerSymbol(Constants.possibleSymbol);                      
           
            Console.WriteLine("YOU ARE PLAYER : " + ch);
            Player humam = new Player(PlayerType.Human, ch);
            Player computer = new Player(PlayerType.Computer, (ch == 'X') ? 'O' : 'X');
            Console.WriteLine("****************************************************************");
            PlayerType first = Toss(DateTime.Now.Second);
            if (first == PlayerType.Computer)
            {
                Console.WriteLine("Computer Won");                
            }
            else
            {
                Console.WriteLine("You Won");                
            } 
            Game gc;
            gc = new Game(humam, computer, first);
            gc.Begin();
            
            Console.ReadLine();
        }

        #endregion

        #region Private Methods

        private static PlayerType Toss(int second)
        {
            Console.WriteLine("---Game toss---");
            if (second % 2 == 0)
            {
                return PlayerType.Human;
            }
            return PlayerType.Computer;
        }

        #endregion
    }
}

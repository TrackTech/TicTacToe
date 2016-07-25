using System;
using System.Linq;

namespace TicTacToe
{
    static class Util
    {
        #region Public Methods 

        public static void PrintAvailable(Cell[] available)
        {
            Console.WriteLine("Available cells are:");
            Console.WriteLine();
            foreach (var c in available)
            {
                Console.Write(c.Coordinates + " ");
            }
        }

        public static void PrintMatrix(Cell[] matrix,int MATRIX_ROWS,int MATRIX_COLUMNS)
        {
            Console.WriteLine(" | 0| 1| 2|");
            Console.WriteLine("-----------");
            for (int i = 0; i < MATRIX_ROWS; i++)
            {
                Console.Write(i + "|");
                for (int j = 0; j < MATRIX_COLUMNS; j++)
                {
                    if (!matrix[(i * MATRIX_ROWS) + j].IsOccupied)
                        Console.Write("  |");
                    else
                        Console.Write(" " + matrix[(i * MATRIX_ROWS) + j].Player.symbol + "|");
                }
                Console.WriteLine();
                Console.WriteLine("-----------");
            }
        }

        public static char GetPlayerSymbol(char[] possibleSymbol)
        {
            char ch;
            while (true)
            {                
                Console.WriteLine("Select your symbol [X/O]");
                try
                {
                    var c1 = Console.ReadKey();
                    ch = Convert.ToChar(c1.Key);
                    Console.WriteLine("character you entered: " + ch);
                    if (possibleSymbol.Contains<char>(ch))
                    {
                        break;
                    }
                }
                catch(Exception){
                    Console.WriteLine("Please try again");
                }
                Console.Clear();
            }
            if (char.IsLower(ch))
            {
                ch = char.ToUpper(ch);
            }
            return ch;
        }

        public static int GetXValue(char[] possibleValues)
        {
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter X value[row]:");
                    var c1 = Console.ReadKey();
                    ch = Convert.ToChar(c1.Key);                
                    if (possibleValues.Contains<char>(ch))
                    {                    
                        break;
                    }
                }
                catch(Exception){
                    Console.WriteLine("Please try again");
                }
            }
            return int.Parse(ch.ToString());            
        }

        public static int GetYValue(char[] possibleValues)
        {
            char ch;
            while (true)
            {
                Console.WriteLine("Enter Y value[column]:");
                try
                {
                    var c1 = Console.ReadKey();
                    ch = Convert.ToChar(c1.Key);
                    if (possibleValues.Contains<char>(ch))
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please try again");
                }
            }
            return int.Parse(ch.ToString());
        }

        #endregion
    }
}

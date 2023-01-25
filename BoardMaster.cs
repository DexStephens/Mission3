using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    public class BoardMaster
    {
        public static void PrintBoard(char[] board)
        {
            Console.WriteLine($"  {board[0]}  | {board[1]}  | {board[2]}  ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"  {board[3]}  |  {board[4]} |  {board[5]} ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"  {board[6]}  |  {board[7]} |  {board[8]} ");
        }

        public static char? IsWinner(char[] board)
        {
            //Check for horizontal winners
            if (board[0] == board[1] && board[1] == board[2])
            {
                return board[0];
            }
            if (board[3] == board[4] && board[4] == board[5])
            {
                return board[3];
            }
            if (board[6] == board[7] && board[7] == board[8])
            {
                return board[6];
            }
            //Check for vertical winners
            if (board[0] == board[3] && board[3] == board[6])
            {
                return board[0];
            }
            if (board[1] == board[4] && board[4] == board[7])
            {
                return board[1];
            }
            if (board[2] == board[5] && board[5] == board[8])
            {
                return board[2];
            }
            //Check for diagonal winners
            if (board[0] == board[4] && board[4] == board[8])
            {
                return board[0];
            }
            if (board[2] == board[4] && board[4] == board[6])
            {
                return board[2];
            }
            return null;
        }

        //new char[9] {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
    }
}

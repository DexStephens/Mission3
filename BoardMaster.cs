using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    public class BoardMaster
    {
        // create the tic tac toe board formatting
        public static void PrintBoard(char[] board)
        {
            Console.WriteLine($"  {board[0]}  |  {board[1]}  |  {board[2]} ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"  {board[3]}  |  {board[4]}  |  {board[5]} ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"  {board[6]}  |  {board[7]}  |  {board[8]} ");
            Console.WriteLine(""); // blank line so output looks better
        }

        // Calculate the winner or determine if result is cat's game
        public static char? IsWinner(char[] board)
        {
            List<char> numList = new() { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            // Check for horizontal winners & output letter of winner
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
            // Check for vertical winners & output letter of winner
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
            // Check for diagonal winners & output letter of winner
            if (board[0] == board[4] && board[4] == board[8])
            {
                return board[0];
            }
            if (board[2] == board[4] && board[4] == board[6])
            {
                return board[2];
            }
            // Return C if cat game
            if (Array.Find(board, x => numList.Contains(x)) == '\0')
            {
                return 'C';
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    public class Driver
    {
		public void StartGame()
		{
			Console.WriteLine("Welcome to the Game!!!");
			char[] gameBoard = new char[] {'1', '2', '3', '4', '5', '6','7','8','9',};
			int counter = 0;

			BoardMaster bm = new BoardMaster();

			

			while (counter < 9)
            {
				BoardMaster.PrintBoard(gameBoard);
				Console.WriteLine("Player 1: Choose your square");
				int turnPlayer1 = 0;
				bool valid = false;

				while (valid == false)
                {
					try
                    {
						turnPlayer1 = Convert.ToInt32(Console.ReadLine());
						if ((turnPlayer1 < 1) || (turnPlayer1 > 9) || (gameBoard[turnPlayer1 - 1] == 'x') || (gameBoard[turnPlayer1 - 1] == 'o'))
						{
							Console.WriteLine("Invalid input or square already used, try again");
						}
						else
						{
							gameBoard[turnPlayer1 - 1] = 'x';
							counter++;
							valid = true;
						}
					}
					catch
                    {
						Console.WriteLine("Invalid input or square already used, try again");
					}
                }
				char? result = BoardMaster.IsWinner(gameBoard);
				if (result != null) {
					if (result == 'C')
                    {
						Console.WriteLine("Cat's Game :(");
                    }
					else
                    {
						Console.WriteLine("Player 1 Wins!!!");
						BoardMaster.PrintBoard(gameBoard);
					}
					break;
				}

				BoardMaster.PrintBoard(gameBoard);
				Console.WriteLine("Player 2: Choose your square");
				int turnPlayer2 = 0;
				valid = false;

				while (valid == false)
                {
					try
					{
						turnPlayer2 = Convert.ToInt32(Console.ReadLine());
						if ((turnPlayer2 < 1) || (turnPlayer2 > 9) || (gameBoard[turnPlayer2 - 1] == 'x') || (gameBoard[turnPlayer2 - 1] == 'o'))
						{
							Console.WriteLine("Invalid input or square already used, try again");
						}
						else
						{
							gameBoard[turnPlayer2 - 1] = 'o';
							counter++;
							valid = true;
						}
					}
					catch {
						Console.WriteLine("Invalid input or square already used, try again");
					}
				}
				char? result_2 = BoardMaster.IsWinner(gameBoard);
				if (result_2 != null)
				{
					if (result_2 == 'C')
					{
						Console.WriteLine("Cat's Game :(");

					}
					else
					{
						Console.WriteLine("Player 2 Wins!!!");
						BoardMaster.PrintBoard(gameBoard);
					}
					break;
				}
			}

		}
	}
}


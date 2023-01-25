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

			BoardMaster.PrintBoard(gameBoard);


		}
	}
}


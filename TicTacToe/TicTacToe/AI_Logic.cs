using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class AI_Logic
    {
        /// <summary>
        /// Random used to make a random move
        /// </summary>
        private Random mRandom;
        /// <summary>
        /// A counter for the number of recursive attempts to make a random choice
        /// </summary>
        private int randomChoiceAttempts;

        /// <summary>
        /// Constructor it instantiate the Random and randomChoiceAttempts
        /// </summary>
        public AI_Logic()
        {
            this.mRandom = new Random();
            this.randomChoiceAttempts = 0;
        }

        /// <summary>
        /// This method is used to determine the move the AI will make
        /// First it checks for a winning move
        /// Then checks for a move to block
        /// If neither are available then it makes a random move
        /// If a random move isnt available a -1 is returned
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <returns></returns>
        public int MakeMove(String[] gameBoard)
        {
            int move = -1;
            // Check for winning move and return it if available
            move = checkForWinMove(gameBoard);
            System.Diagnostics.Debug.WriteLine("\tmove = " + move);
            if (move != -1)
            {
                return move;
            }
            // Check for blocking move and return it if available
            move = checkForBlockMove(gameBoard);
            System.Diagnostics.Debug.WriteLine("\tmove = " + move);
            if (move != -1)
            {
                return move;
            }
            // make a random move, if none available -1 is returned
            move = makeRandomMove(gameBoard);
            System.Diagnostics.Debug.WriteLine("\tmove = " + move);
            return move;
        }

        /// <summary>
        /// This method checks for all the available moves to block a win and returns the position if available
        /// if there is no block move a -1 is returned
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <returns></returns>
        private int checkForBlockMove(String[] gameBoard)
        {
            System.Diagnostics.Debug.WriteLine("\tIN CHECK BLOCK MOVE");
            // diag ltop to rbot
            if (gameBoard[0].Equals("X") && gameBoard[4].Equals("X") && !gameBoard[8].Equals("O"))
            {
                return 8;
            }
            else if (gameBoard[0].Equals("X") && gameBoard[8].Equals("X") && !gameBoard[4].Equals("O"))
            {
                return 4;
            }
            else if (gameBoard[4].Equals("X") && gameBoard[8].Equals("X") && !gameBoard[0].Equals("O"))
            {
                return 0;
            }

            // diag lbot to rtop
            else if (gameBoard[2].Equals("X") && gameBoard[4].Equals("X") && !gameBoard[6].Equals("O"))
            {
                return 6;
            }
            else if (gameBoard[2].Equals("X") && gameBoard[6].Equals("X") && !gameBoard[4].Equals("O"))
            {
                return 4;
            }
            else if (gameBoard[4].Equals("X") && gameBoard[6].Equals("X") && !gameBoard[2].Equals("O"))
            {
                return 2;
            }

            // col 1 
            else if (gameBoard[0].Equals("X") && gameBoard[3].Equals("X") && !gameBoard[6].Equals("O"))
            {
                return 6;
            }
            else if (gameBoard[0].Equals("X") && gameBoard[6].Equals("X") && !gameBoard[3].Equals("O"))
            {
                return 3;
            }
            else if (gameBoard[3].Equals("X") && gameBoard[6].Equals("X") && !gameBoard[0].Equals("O"))
            {
                return 0;
            }

            // col 2
            else if (gameBoard[1].Equals("X") && gameBoard[4].Equals("X") && !gameBoard[7].Equals("O"))
            {
                return 7;
            }
            else if (gameBoard[1].Equals("X") && gameBoard[7].Equals("X") && !gameBoard[4].Equals("O"))
            {
                return 4;
            }
            else if (gameBoard[4].Equals("X") && gameBoard[7].Equals("X") && !gameBoard[1].Equals("O"))
            {
                return 1;
            }

            // col 3
            else if (gameBoard[2].Equals("X") && gameBoard[5].Equals("X") && !gameBoard[8].Equals("O"))
            {
                return 8;
            }
            else if (gameBoard[2].Equals("X") && gameBoard[8].Equals("X") && !gameBoard[5].Equals("O"))
            {
                return 5;
            }
            else if (gameBoard[5].Equals("X") && gameBoard[8].Equals("X") && !gameBoard[2].Equals("O"))
            {
                return 2;
            }

            // row 1
            else if (gameBoard[0].Equals("X") && gameBoard[1].Equals("X") && !gameBoard[2].Equals("O"))
            {
                return 2;
            }
            else if (gameBoard[0].Equals("X") && gameBoard[2].Equals("X") && !gameBoard[1].Equals("O"))
            {
                return 1;
            }
            else if (gameBoard[1].Equals("X") && gameBoard[2].Equals("X") && !gameBoard[0].Equals("O"))
            {
                return 0;
            }

            // row 2
            else if (gameBoard[3].Equals("X") && gameBoard[4].Equals("X") && !gameBoard[5].Equals("O"))
            {
                return 5;
            }
            else if (gameBoard[3].Equals("X") && gameBoard[5].Equals("X") && !gameBoard[4].Equals("O"))
            {
                return 4;
            }
            else if (gameBoard[4].Equals("X") && gameBoard[5].Equals("X") && !gameBoard[3].Equals("O"))
            {
                return 3;
            }

            // row 3
            else if (gameBoard[6].Equals("X") && gameBoard[7].Equals("X") && !gameBoard[8].Equals("O"))
            {
                return 8;
            }
            else if (gameBoard[6].Equals("X") && gameBoard[8].Equals("X") && !gameBoard[7].Equals("O"))
            {
                return 7;
            }
            else if (gameBoard[7].Equals("X") && gameBoard[8].Equals("X") && !gameBoard[6].Equals("O"))
            {
                return 6;
            }

            // default return
            return -1;
        }

        /// <summary>
        /// This method checks for all the available moves to win and returns the position if available
        /// if there is no win move a -1 is returned
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <returns></returns>
        private int checkForWinMove(String[] gameBoard)
        {
            System.Diagnostics.Debug.WriteLine("\tIN CHECK WIN MOVE");
            // diag ltop to rbot
            if (gameBoard[0].Equals("O") && gameBoard[4].Equals("O") && !gameBoard[8].Equals("X"))
            {
                return 8;
            }
            else if (gameBoard[0].Equals("O") && gameBoard[8].Equals("O") && !gameBoard[4].Equals("X"))
            {
                return 4;
            }
            else if (gameBoard[4].Equals("O") && gameBoard[8].Equals("O") && !gameBoard[0].Equals("X"))
            {
                return 0;
            }

            // diag lbot to rtop
            else if (gameBoard[2].Equals("O") && gameBoard[4].Equals("O") && !gameBoard[6].Equals("X"))
            {
                return 6;
            }
            else if (gameBoard[2].Equals("O") && gameBoard[6].Equals("O") && !gameBoard[4].Equals("X"))
            {
                return 4;
            }
            else if (gameBoard[4].Equals("O") && gameBoard[6].Equals("O") && !gameBoard[2].Equals("X"))
            {
                return 2;
            }

            // col 1 
            else if (gameBoard[0].Equals("O") && gameBoard[3].Equals("O") && !gameBoard[6].Equals("X"))
            {
                return 6;
            }
            else if (gameBoard[0].Equals("O") && gameBoard[6].Equals("O") && !gameBoard[3].Equals("X"))
            {
                return 3;
            }
            else if (gameBoard[3].Equals("O") && gameBoard[6].Equals("O") && !gameBoard[0].Equals("X"))
            {
                return 0;
            }

            // col 2
            else if (gameBoard[1].Equals("O") && gameBoard[4].Equals("O") && !gameBoard[7].Equals("X"))
            {
                return 7;
            }
            else if (gameBoard[1].Equals("O") && gameBoard[7].Equals("O") && !gameBoard[4].Equals("X"))
            {
                return 4;
            }
            else if (gameBoard[4].Equals("O") && gameBoard[7].Equals("O") && !gameBoard[1].Equals("X"))
            {
                return 1;
            }

            // col 3
            else if (gameBoard[2].Equals("O") && gameBoard[5].Equals("O") && !gameBoard[8].Equals("X"))
            {
                return 8;
            }
            else if (gameBoard[2].Equals("O") && gameBoard[8].Equals("O") && !gameBoard[5].Equals("X"))
            {
                return 5;
            }
            else if (gameBoard[5].Equals("O") && gameBoard[8].Equals("O") && !gameBoard[2].Equals("X"))
            {
                return 2;
            }

            // row 1
            else if (gameBoard[0].Equals("O") && gameBoard[1].Equals("O") && !gameBoard[2].Equals("X"))
            {
                return 2;
            }
            else if (gameBoard[0].Equals("O") && gameBoard[2].Equals("O") && !gameBoard[1].Equals("X"))
            {
                return 1;
            }
            else if (gameBoard[1].Equals("O") && gameBoard[2].Equals("O") && !gameBoard[0].Equals("X"))
            {
                return 0;
            }

            // row 2
            else if (gameBoard[3].Equals("O") && gameBoard[4].Equals("O") && !gameBoard[5].Equals("X"))
            {
                return 5;
            }
            else if (gameBoard[3].Equals("O") && gameBoard[5].Equals("O") && !gameBoard[4].Equals("X"))
            {
                return 4;
            }
            else if (gameBoard[4].Equals("O") && gameBoard[5].Equals("O") && !gameBoard[3].Equals("X"))
            {
                return 3;
            }

            // row 3
            else if (gameBoard[6].Equals("O") && gameBoard[7].Equals("O") && !gameBoard[8].Equals("X"))
            {
                return 8;
            }
            else if (gameBoard[6].Equals("O") && gameBoard[8].Equals("O") && !gameBoard[7].Equals("X"))
            {
                return 7;
            }
            else if (gameBoard[7].Equals("O") && gameBoard[8].Equals("O") && !gameBoard[6].Equals("X"))
            {
                return 6;
            }

            // default return 
            return -1;
        }

        /// <summary>
        /// This method makes a random choice for position 1-9 on the gameBoard
        /// First the method makes a List and adds the index number of every empty string
        /// in gameBoard to the list. A random number is selected between 0 and length of the list
        /// The index number of gameBoard saved at the index number = randomNum of availableMoves list
        /// is then returned if the list has elements otherwise -1 is returned
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <returns>int position of available move</returns>
        private int makeRandomMove(String[] gameBoard)
        {
            System.Diagnostics.Debug.WriteLine("\tIN MAKE RANDOM MOVE");
            List<int> availableMoves = new List<int>();
            int availableCount = 0;
            for (int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i].Equals(""))
                {
                    System.Diagnostics.Debug.WriteLine("Found Available Move @ index =" + i);
                    availableCount++;
                    availableMoves.Add(i);
                }
            }
            int choice = -1;
            int randNum = -1;
            if (availableCount > 0)
            {
                randNum = mRandom.Next(0, availableCount);
                choice = availableMoves.ElementAt(randNum);
            }
            return choice;
        }
    }
}

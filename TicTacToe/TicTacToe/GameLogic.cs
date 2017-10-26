using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// This class is used to handle all the game logic for the Tic Tac Toe GUI
    /// </summary>
    class GameLogic
    {
        /// <summary>
        /// field to hold the number of player 1 wins
        /// </summary>
        private int player1WinCount;
        /// <summary>
        /// field to hold the number of player 2 wins
        /// </summary>
        private int player2WinCount;
        /// <summary>
        /// field to hold the number of ties the game has had
        /// </summary>
        private int playerTieCount;


        /// <summary>
        /// Constructor to instantiate the fields
        /// </summary>
        public GameLogic()
        {
            player1WinCount = 0;
            player2WinCount = 0;
            playerTieCount = 0;
        }

        /// <summary>
        /// This method uses the gameBoard array from the Form1 class to check all the possible ways a player can win
        /// If there is a winner the result is returned as a string
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <returns>String representation of winner and the way they won</returns>
        public String CheckForWin(String[] gameBoard)
        {
            if (CheckXDiagonal(gameBoard).Equals("X Diag1"))
            {
                this.player1WinCount++;
                return "X Diag1";
            }
            if (CheckXDiagonal(gameBoard).Equals("X Diag2"))
            {
                this.player1WinCount++;
                return "X Diag2";
            }
            if (CheckXColumn(gameBoard).Equals("X Col1"))
            {
                this.player1WinCount++;
                return "X Col1";
            }
            if (CheckXColumn(gameBoard).Equals("X Col2"))
            {
                this.player1WinCount++;
                return "X Col2";
            }
            if (CheckXColumn(gameBoard).Equals("X Col3"))
            {
                this.player1WinCount++;
                return "X Col3";
            }
            if (CheckXRow(gameBoard).Equals("X Row1"))
            {
                this.player1WinCount++;
                return "X Row1";
            }
            if (CheckXRow(gameBoard).Equals("X Row2"))
            {
                this.player1WinCount++;
                return "X Row2";
            }
            if (CheckXRow(gameBoard).Equals("X Row3"))
            {
                this.player1WinCount++;
                return "X Row3";
            }
            if (CheckODiagonal(gameBoard).Equals("O Diag1"))
            {
                this.player2WinCount++;
                return "O Diag1";
            }
            if (CheckODiagonal(gameBoard).Equals("O Diag2"))
            {
                this.player2WinCount++;
                return "O Diag2";
            }
            if (CheckOColumn(gameBoard).Equals("O Col1"))
            {
                this.player2WinCount++;
                return "O Col1";
            }
            if (CheckOColumn(gameBoard).Equals("O Col2"))
            {
                return "O Col2";
            }
            if (CheckOColumn(gameBoard).Equals("O Col3"))
            {
                this.player2WinCount++;
                return "O Col3";
            }
            if (CheckORow(gameBoard).Equals("O Row1"))
            {
                this.player2WinCount++;
                return "O Row1";
            }
            if (CheckORow(gameBoard).Equals("O Row2"))
            {
                this.player2WinCount++;
                return "O Row2";
            }
            if (CheckORow(gameBoard).Equals("O Row3"))
            {
                this.player2WinCount++;
                return "O Row3";
            }
            if (CheckTie(gameBoard))
            {
                this.playerTieCount++;
                return "Tie";
            }
            return "";
        }

        /// <summary>
        /// Getter to return the value of player1WinCount
        /// </summary>
        /// <returns>int value of player1WinCount</returns>
        public int GetPlayer1WinCount()
        {
            return this.player1WinCount;
        }

        /// <summary>
        /// Getter to return the value of player2WinCount
        /// </summary>
        /// <returns>int value of player2WinCount</returns>
        public int GetPlayer2WinCount()
        {
            return this.player2WinCount;
        }

        /// <summary>
        /// Getter to return the value of playerWinCount
        /// </summary>
        /// <returns>int value of playerTieCount</returns>
        public int GetPlayerTieCount()
        {
            return this.playerTieCount;
        }

        /// <summary>
        /// This method checks that all the positions in the game board array are filled with X or O
        /// if they are then it returns true to represent the game is a tie
        /// else it returns false
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <returns></returns>
        private Boolean CheckTie(String[] gameBoard)
        {
            int count = 0;
            foreach (String s in gameBoard)
            {
                if (s.Equals("X") || s.Equals("O"))
                {
                    count++;
                }
            }
            if (count == 9)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// This method checks the two diagonals for Player X to see if they won by checking the 
        /// diagonal positions in the gameBoard array and 
        /// if they won it returns a String representation of the winner and the way they won
        /// else it returns an empty string
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <returns>String representation of winner and the way they won</returns>
        private String CheckXDiagonal(String[] gameBoard)
        {
            if (gameBoard[0].Equals("X") && gameBoard[4].Equals("X") && gameBoard[8].Equals("X"))
            {
                return "X Diag1";
            }
            if (gameBoard[2].Equals("X") && gameBoard[4].Equals("X") && gameBoard[6].Equals("X"))
            {
                return "X Diag2";
            }
            return "";
        }

        /// <summary>
        /// This method checks the four columns for Player X to see if they won by checking the 
        /// column positions in the gameBoard array and 
        /// if they won it returns a String representation of the winner and the way they won
        /// else it returns an empty string
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <returns>String representation of winner and the way they won</returns>
        private String CheckXColumn(String[] gameBoard)
        {
            if (gameBoard[0].Equals("X") && gameBoard[3].Equals("X") && gameBoard[6].Equals("X"))
            {
                return "X Col1";
            }
            if (gameBoard[1].Equals("X") && gameBoard[4].Equals("X") && gameBoard[7].Equals("X"))
            {
                return "X Col2";
            }
            if (gameBoard[2].Equals("X") && gameBoard[5].Equals("X") && gameBoard[8].Equals("X"))
            {
                return "X Col3";
            }
            return "";
        }

        /// <summary>
        /// This method checks the four rows for Player X to see if they won by checking the 
        /// row positions in the gameBoard array and 
        /// if they won it returns a String representation of the winner and the way they won
        /// else it returns an empty string
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <returns>String representation of winner and the way they won</returns>
        private String CheckXRow(String[] gameBoard)
        {
            if (gameBoard[0].Equals("X") && gameBoard[1].Equals("X") && gameBoard[2].Equals("X"))
            {
                return "X Row1";
            }
            if (gameBoard[3].Equals("X") && gameBoard[4].Equals("X") && gameBoard[5].Equals("X"))
            {
                return "X Row2";
            }
            if (gameBoard[6].Equals("X") && gameBoard[7].Equals("X") && gameBoard[8].Equals("X"))
            {
                return "X Row3";
            }
            return "";
        }

        /// <summary>
        /// This method checks the two diagonals for Player O to see if they won by checking the 
        /// diagonal positions in the gameBoard array and 
        /// if they won it returns a String representation of the winner and the way they won
        /// else it returns an empty string
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <returns>String representation of winner and the way they won</returns>
        private String CheckODiagonal(String[] gameBoard)
        {
            if (gameBoard[0].Equals("O") && gameBoard[4].Equals("O") && gameBoard[8].Equals("O"))
            {
                return "O Diag1";
            }
            if (gameBoard[2].Equals("O") && gameBoard[4].Equals("O") && gameBoard[6].Equals("O"))
            {
                return "O Diag2";
            }
            return "";
        }

        /// <summary>
        /// This method checks the four columns for Player O to see if they won by checking the 
        /// column positions in the gameBoard array and 
        /// if they won it returns a String representation of the winner and the way they won
        /// else it returns an empty string
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <returns>String representation of winner and the way they won</returns>
        private String CheckOColumn(String[] gameBoard)
        {
            if (gameBoard[0].Equals("O") && gameBoard[3].Equals("O") && gameBoard[6].Equals("O"))
            {
                return "O Col1";
            }
            if (gameBoard[1].Equals("O") && gameBoard[4].Equals("O") && gameBoard[7].Equals("O"))
            {
                return "O Col2";
            }
            if (gameBoard[2].Equals("O") && gameBoard[5].Equals("O") && gameBoard[8].Equals("O"))
            {
                return "O Col3";
            }
            return "";
        }

        /// <summary>
        /// This method checks the four rows for Player O to see if they won by checking the 
        /// row positions in the gameBoard array and 
        /// if they won it returns a String representation of the winner and the way they won
        /// else it returns an empty string
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <returns>String representation of winner and the way they won</returns>
        private String CheckORow(String[] gameBoard)
        {
            if (gameBoard[0].Equals("O") && gameBoard[1].Equals("O") && gameBoard[2].Equals("O"))
            {
                return "O Row1";
            }
            if (gameBoard[3].Equals("O") && gameBoard[4].Equals("O") && gameBoard[5].Equals("O"))
            {
                return "O Row2";
            }
            if (gameBoard[6].Equals("O") && gameBoard[7].Equals("O") && gameBoard[8].Equals("O"))
            {
                return "O Row3";
            }
            return "";
        }
    }
}

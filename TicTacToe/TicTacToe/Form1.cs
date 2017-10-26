using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The fields used for global access within the class
        /// The Buttons are the buttons for the tic tac toe game board
        /// </summary>
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        /// <summary>
        /// An array that represents the game board to update values and pass to the GameLogic class to be evaluated
        /// </summary>
        private String[] gameBoard;
        /// <summary>
        /// The GameLogic class is used to handle the business logic for the Tic Tac Toe game
        /// </summary>
        private GameLogic mGameLogic;
        /// <summary>
        /// This AI Logic class is used to handle moves made by AI if AI game is started
        /// </summary>
        private AI_Logic mAI_Logic;
        /// <summary>
        /// A boolean to check if AI gameplay is enabled
        /// </summary>
        private Boolean AI_Enabled;
        /// <summary>
        /// The player is used to determine what players turn it is
        /// Also the string value is used to update the Text of the game board buttons
        /// and to update the values in the gameBoard array
        /// </summary>
        private Player currentPlayer;
        /// <summary>
        /// The Player enum is used for currentPlayer
        /// </summary>
        public enum Player
        {
            X,
            O
        }

        /// <summary>
        /// Constructor to initialize the UI and the game components
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.btn1 = button1;
            this.btn2 = button2;
            this.btn3 = button3;
            this.btn4 = button4;
            this.btn5 = button5;
            this.btn6 = button6;
            this.btn7 = button7;
            this.btn8 = button8;
            this.btn9 = button9;
            InitializeGame();
        }

        /// <summary>
        /// This method sets the game to its initial state
        /// Instantiated:
        ///     the gameBoard array and puts default empty strings in it
        ///     the GameLogic class that handles the game logic for winning
        /// Sets:
        ///     GameStatistics and GameStatus Text to default values
        ///     Button colors back to default values
        /// Enables:
        ///     All buttons to be clickable
        /// </summary>
        private void InitializeGame()
        {
            this.gameBoard = new String[9];
            for (int i = 0; i < 9; i++)
            {
                this.gameBoard[i] = "";
            }
            this.mGameLogic = new GameLogic();
            this.currentPlayer = Player.X;
            this.AI_Enabled = false;
            this.mAI_Logic = new AI_Logic();
            setGameStatisticsText();
            setGameStatusText("");
            enableAllButtons();
            resetAllButtonColor();
            resetAllButtonText();

        }

        /// <summary>
        /// This method is called when a player calls start game the difference between this and InitializeGame
        /// is that this method will not create a new GameLogic where applications data is stored
        /// </summary>
        private void StartGame()
        {
            this.gameBoard = new String[9];
            for (int i = 0; i < 9; i++)
            {
                this.gameBoard[i] = "";
            }
            this.currentPlayer = Player.X;
            setGameStatisticsText();
            setGameStatusText("");
            enableAllButtons();
            resetAllButtonColor();
            resetAllButtonText();
            this.AI_Enabled = false;
        }

        /// <summary>
        /// This method is called when a player clicks the Start Game VS AI button
        /// The difference between this and StartGame() is that this method sets the AI_Enabled flag to true
        /// is that this method will not create a new GameLogic where applications data is stored
        /// </summary>
        private void StartAIGame()
        {
            this.gameBoard = new String[9];
            for (int i = 0; i < 9; i++)
            {
                this.gameBoard[i] = "";
            }
            this.currentPlayer = Player.X;
            setGameStatisticsText();
            setGameStatusText("");
            enableAllButtons();
            resetAllButtonColor();
            resetAllButtonText();
            this.AI_Enabled = true;
        }

        /// <summary>
        /// This method instantiates result by calling the GameLogics CheckForWin() method
        /// The result is checked in a switch to update the UI with:
        ///     disabling all game button clicks
        ///     highlighting the winning move
        ///     setting the GameStatusRichText to the winner
        ///     updating the GameStatisticsRichText
        /// </summary>
        private void checkWinner()
        {
            String result = this.mGameLogic.CheckForWin(this.gameBoard);
            System.Diagnostics.Debug.WriteLine("\tIn GUI checkWinner()");
            System.Diagnostics.Debug.WriteLine("\tresult = " + result);
            switch (result)
            {
                case "X Diag1":
                    setGameStatusText("Player 1 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn1, btn5, btn9);
                    disableAllButtons();
                    break;
                case "X Diag2":
                    setGameStatusText("Player 1 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn3, btn5, btn7);
                    disableAllButtons();
                    break;
                case "X Col1":
                    setGameStatusText("Player 1 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn1, btn4, btn7);
                    disableAllButtons();
                    break;
                case "X Col2":
                    setGameStatusText("Player 1 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn2, btn5, btn8);
                    disableAllButtons();
                    break;
                case "X Col3":
                    setGameStatusText("Player 1 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn3, btn6, btn9);
                    disableAllButtons();
                    break;
                case "X Row1":
                    setGameStatusText("Player 1 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn1, btn2, btn3);
                    disableAllButtons();
                    break;
                case "X Row2":
                    setGameStatusText("Player 1 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn4, btn5, btn6);
                    disableAllButtons();
                    break;
                case "X Row3":
                    setGameStatusText("Player 1 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn7, btn8, btn9);
                    disableAllButtons();
                    break;
                case "O Diag1":
                    setGameStatusText("Player 2 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn1, btn5, btn9);
                    disableAllButtons();
                    break;
                case "O Diag2":
                    setGameStatusText("Player 2 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn3, btn5, btn7);
                    disableAllButtons();
                    break;
                case "O Col1":
                    setGameStatusText("Player 2 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn1, btn4, btn7);
                    disableAllButtons();
                    break;
                case "O Col2":
                    setGameStatusText("Player 2 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn2, btn5, btn8);
                    disableAllButtons();
                    break;
                case "O Col3":
                    setGameStatusText("Player 2 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn3, btn6, btn9);
                    disableAllButtons();
                    break;
                case "O Row1":
                    setGameStatusText("Player 2 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn1, btn2, btn3);
                    disableAllButtons();
                    break;
                case "O Row2":
                    setGameStatusText("Player 2 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn4, btn5, btn6);
                    disableAllButtons();
                    break;
                case "O Row3":
                    setGameStatusText("Player 2 Wins");
                    setGameStatisticsText();
                    highlightWinMove(btn7, btn8, btn9);
                    disableAllButtons();
                    break;
                case "Tie":
                    setGameStatusText("Tie Game");
                    setGameStatisticsText();
                    disableAllButtons();
                    break;
                default:
                    setGameStatusText("");
                    break;
            }
        }

        /// <summary>
        /// This method is used to set the text of richTextBoxGameStatus with the passed parameter String text
        /// </summary>
        /// <param name="text"></param>
        private void setGameStatusText(String text)
        {
            richTextBoxGameStatus.Text = "\n\n\n\t\t\t" + text;
        }

        /// <summary>
        /// This method sets the text of richTextBoxGameStatistics by getting the values stored in
        /// the current instance of the GameLogic class
        /// </summary>
        private void setGameStatisticsText()
        {
            richTextBoxGameStatistics.Text = ""
                + "\n\n\n\t\tPlayer 1 Wins: \t"
                + this.mGameLogic.GetPlayer1WinCount()
                + "\n\n\t\tPlayer 2 Wins: \t"
                + this.mGameLogic.GetPlayer2WinCount()
                + "\n\n\t\t\tTies: \t"
                + this.mGameLogic.GetPlayerTieCount();
        }

        /// <summary>
        /// This method disables all game buttons used for playing tic tac toe
        /// </summary>
        private void disableAllButtons()
        {
            this.btn1.Enabled = false;
            this.btn2.Enabled = false;
            this.btn3.Enabled = false;
            this.btn4.Enabled = false;
            this.btn5.Enabled = false;
            this.btn6.Enabled = false;
            this.btn7.Enabled = false;
            this.btn8.Enabled = false;
            this.btn9.Enabled = false;
        }

        /// <summary>
        /// This method enables all game buttons used for playing tic tac toe
        /// </summary>
        private void enableAllButtons()
        {
            this.btn1.Enabled = true;
            this.btn2.Enabled = true;
            this.btn3.Enabled = true;
            this.btn4.Enabled = true;
            this.btn5.Enabled = true;
            this.btn6.Enabled = true;
            this.btn7.Enabled = true;
            this.btn8.Enabled = true;
            this.btn9.Enabled = true;
        }

        /// <summary>
        /// This method resets the background color of all game buttons used for playing tic tac toe
        /// </summary>
        private void resetAllButtonColor()
        {
            this.btn1.BackColor = Color.LightGray;
            this.btn2.BackColor = Color.LightGray;
            this.btn3.BackColor = Color.LightGray;
            this.btn4.BackColor = Color.LightGray;
            this.btn5.BackColor = Color.LightGray;
            this.btn6.BackColor = Color.LightGray;
            this.btn7.BackColor = Color.LightGray;
            this.btn8.BackColor = Color.LightGray;
            this.btn9.BackColor = Color.LightGray;
        }

        /// <summary>
        /// This method resets the text of all game buttons used for playing tic tac toe
        /// back to empty strings
        /// </summary>
        private void resetAllButtonText()
        {
            this.btn1.Text = "";
            this.btn2.Text = "";
            this.btn3.Text = "";
            this.btn4.Text = "";
            this.btn5.Text = "";
            this.btn6.Text = "";
            this.btn7.Text = "";
            this.btn8.Text = "";
            this.btn9.Text = "";
        }

        /// <summary>
        /// This method is used to highlight the winning game move in the UI by changing the
        /// background color of each button passed in as a parameter. These buttons are passed in
        /// when the CheckWin() method evaluates something as a win / true;
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <param name="b3"></param>
        private void highlightWinMove(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.Yellow;
            b2.BackColor = Color.Yellow;
            b3.BackColor = Color.Yellow;
        }

        /// <summary>
        /// This is the method that handles the on click event of the startGameBtn
        /// It calls the StartGame method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startGameBtn_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        /// <summary>
        /// This is the method that handles the on click event of button1 of the tic tac toe board
        /// The buttons text is updated to the String value Player currentPlayer
        /// The button is disabled
        /// The value at gameBoard[0] is updated to the String value of Player currentPlayer
        /// The Player currentPlayer is changed to the opposite of it's current value
        /// Then checkWinner() is called to check if the game has a winner or a tie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            btn1.Text = currentPlayer.ToString();
            btn1.Enabled = false;
            gameBoard[0] = currentPlayer.ToString();
            currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
            checkWinner();
            if (AI_Enabled)
            {
                if (currentPlayer.ToString().Equals("O"))
                {
                    AI_MakeMove();
                }
            }
        }

        /// <summary>
        /// This is the method that handles the on click event of button2 of the tic tac toe board
        /// The buttons text is updated to the String value Player currentPlayer
        /// The button is disabled
        /// The value at gameBoard[1] is updated to the String value of Player currentPlayer
        /// The Player currentPlayer is changed to the opposite of it's current value
        /// Then checkWinner() is called to check if the game has a winner or a tie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            btn2.Text = currentPlayer.ToString();
            btn2.Enabled = false;
            gameBoard[1] = currentPlayer.ToString();
            currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
            checkWinner();
            if (AI_Enabled)
            {
                if (currentPlayer.ToString().Equals("O"))
                {
                    AI_MakeMove();
                }
            }
        }

        /// <summary>
        /// This is the method that handles the on click event of button3 of the tic tac toe board
        /// The buttons text is updated to the String value Player currentPlayer
        /// The button is disabled
        /// The value at gameBoard[2] is updated to the String value of Player currentPlayer
        /// The Player currentPlayer is changed to the opposite of it's current value
        /// Then checkWinner() is called to check if the game has a winner or a tie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            btn3.Text = currentPlayer.ToString();
            btn3.Enabled = false;
            gameBoard[2] = currentPlayer.ToString();
            currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
            checkWinner();
            if (AI_Enabled)
            {
                if (currentPlayer.ToString().Equals("O"))
                {
                    AI_MakeMove();
                }
            }
        }

        /// <summary>
        /// This is the method that handles the on click event of button4 of the tic tac toe board
        /// The buttons text is updated to the String value Player currentPlayer
        /// The button is disabled
        /// The value at gameBoard[3] is updated to the String value of Player currentPlayer
        /// The Player currentPlayer is changed to the opposite of it's current value
        /// Then checkWinner() is called to check if the game has a winner or a tie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            btn4.Text = currentPlayer.ToString();
            btn4.Enabled = false;
            gameBoard[3] = currentPlayer.ToString();
            currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
            checkWinner();
            if (AI_Enabled)
            {
                if (currentPlayer.ToString().Equals("O"))
                {
                    AI_MakeMove();
                }
            }
        }

        /// <summary>
        /// This is the method that handles the on click event of button5 of the tic tac toe board
        /// The buttons text is updated to the String value Player currentPlayer
        /// The button is disabled
        /// The value at gameBoard[4] is updated to the String value of Player currentPlayer
        /// The Player currentPlayer is changed to the opposite of it's current value
        /// Then checkWinner() is called to check if the game has a winner or a tie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            btn5.Text = currentPlayer.ToString();
            btn5.Enabled = false;
            gameBoard[4] = currentPlayer.ToString();
            currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
            checkWinner();
            if (AI_Enabled)
            {
                if (currentPlayer.ToString().Equals("O"))
                {
                    AI_MakeMove();
                }
            }
        }

        /// <summary>
        /// This is the method that handles the on click event of button6 of the tic tac toe board
        /// The buttons text is updated to the String value Player currentPlayer
        /// The button is disabled
        /// The value at gameBoard[5] is updated to the String value of Player currentPlayer
        /// The Player currentPlayer is changed to the opposite of it's current value
        /// Then checkWinner() is called to check if the game has a winner or a tie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            btn6.Text = currentPlayer.ToString();
            btn6.Enabled = false;
            gameBoard[5] = currentPlayer.ToString();
            currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
            checkWinner();
            if (AI_Enabled)
            {
                if (currentPlayer.ToString().Equals("O"))
                {
                    AI_MakeMove();
                }
            }
        }

        /// <summary>
        /// This is the method that handles the on click event of button7 of the tic tac toe board
        /// The buttons text is updated to the String value Player currentPlayer
        /// The button is disabled
        /// The value at gameBoard[6] is updated to the String value of Player currentPlayer
        /// The Player currentPlayer is changed to the opposite of it's current value
        /// Then checkWinner() is called to check if the game has a winner or a tie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            btn7.Text = currentPlayer.ToString();
            btn7.Enabled = false;
            gameBoard[6] = currentPlayer.ToString();
            currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
            checkWinner();
            if (AI_Enabled)
            {
                if (currentPlayer.ToString().Equals("O"))
                {
                    AI_MakeMove();
                }
            }
        }

        /// <summary>
        /// This is the method that handles the on click event of button8 of the tic tac toe board
        /// The buttons text is updated to the String value Player currentPlayer
        /// The button is disabled
        /// The value at gameBoard[7] is updated to the String value of Player currentPlayer
        /// The Player currentPlayer is changed to the opposite of it's current value
        /// Then checkWinner() is called to check if the game has a winner or a tie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            btn8.Text = currentPlayer.ToString();
            btn8.Enabled = false;
            gameBoard[7] = currentPlayer.ToString();
            currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
            checkWinner();
            if (AI_Enabled)
            {
                if (currentPlayer.ToString().Equals("O"))
                {
                    AI_MakeMove();
                }
            }
        }

        /// <summary>
        /// This is the method that handles the on click event of button9 of the tic tac toe board
        /// The buttons text is updated to the String value Player currentPlayer
        /// The button is disabled
        /// The value at gameBoard[8] is updated to the String value of Player currentPlayer
        /// The Player currentPlayer is changed to the opposite of it's current value
        /// Then checkWinner() is called to check if the game has a winner or a tie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            btn9.Text = currentPlayer.ToString();
            btn9.Enabled = false;
            gameBoard[8] = currentPlayer.ToString();
            currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
            checkWinner();
            if (AI_Enabled)
            {
                if (currentPlayer.ToString().Equals("O"))
                {
                    AI_MakeMove();
                }
            }
        }

        /// <summary>
        /// This method handles the on click event of buttonResetGame
        /// InitializeGame() method is called to reset the game to its initial state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResetGame_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        /// <summary>
        /// This method handles the on click event of startAIGameBtn
        /// StartAIGame() method is called to start the game with AI_Enabled flag set to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            StartAIGame();
        }

        private void AI_MakeMove()
        {
            int move = mAI_Logic.MakeMove(this.gameBoard);
            if (move != -1)
            {
                switch (move)
                {
                    case 0:
                        this.btn1.PerformClick();
                        break;
                    case 1:
                        this.btn2.PerformClick();
                        break;
                    case 2:
                        this.btn3.PerformClick();
                        break;
                    case 3:
                        this.btn4.PerformClick();
                        break;
                    case 4:
                        this.btn5.PerformClick();
                        break;
                    case 5:
                        this.btn6.PerformClick();
                        break;
                    case 6:
                        this.btn7.PerformClick();
                        break;
                    case 7:
                        this.btn8.PerformClick();
                        break;
                    case 8:
                        this.btn9.PerformClick();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

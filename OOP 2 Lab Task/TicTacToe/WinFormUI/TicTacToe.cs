using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class TicTacToe : Form
    {
        List<Button> horizontalMoves = new List<Button>();
        List<Button> verticalMoves = new List<Button>();
        List<Button> diagonalMoves = new List<Button>();
        List<Button> allMoves = new List<Button>();
        static string firstPlayerName;
        static string secondPlayerName;
        public TicTacToe()
        {
            InitializeComponent();
            Rematch.Enabled = false;
            NewGame.Enabled = false;
            allMoves.Add(b1);
            allMoves.Add(b2);
            allMoves.Add(b3);
            allMoves.Add(b4);
            allMoves.Add(b5);
            allMoves.Add(b6);
            allMoves.Add(b7);
            allMoves.Add(b8);
            allMoves.Add(b9);
        }

        public static void SetPlayerName(string player1, string player2)
        {
            firstPlayerName = player1;
            secondPlayerName = player2;

        }


        private void ChangeTurn()
        {
            if (CurrentPlayer.Text == firstPlayerName)
            {
                CurrentPlayer.Text = secondPlayerName;
            }
            else
            {
                CurrentPlayer.Text = firstPlayerName;
            }
        }

        private void ShowWinner(string playerName)
        {

            MessageBox.Show($"Winner is {playerName}");
            foreach (var item in allMoves)
            {
                item.Enabled = false;
            }
            CurrentPlayer.Text = "";
            Rematch.Enabled = true;
            NewGame.Enabled = true;
        }
        private void ShowTie()
        {
            MessageBox.Show("Its a tie !!!");
            foreach (var item in allMoves)
            {
                item.Enabled = false;
            }
            CurrentPlayer.Text = "";
            Rematch.Enabled = true;
            NewGame.Enabled = true;
        }

        private bool CheckTie()
        {
            foreach (var item in allMoves)
            {
                if (String.IsNullOrWhiteSpace(item.Text))
                {
                    return false;
                }
            }

            return true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (CurrentPlayer.Text == firstPlayerName)
            {
                if (String.IsNullOrWhiteSpace(button.Text))
                {
                    button.Text = "X";
                    if (CheckWinner("X"))
                    {
                        ShowWinner(CurrentPlayer.Text);
                    }
                    else if (CheckTie())
                    {
                        ShowTie();
                    }
                    else
                    {
                        ChangeTurn();

                    }
                }

            }
            else
            {
                if (String.IsNullOrWhiteSpace(button.Text))
                {
                    button.Text = "O";
                    if (CheckWinner("O"))
                    {
                        ShowWinner(CurrentPlayer.Text);
                    }
                    else if (CheckTie())
                    {
                        ShowTie();
                    }
                    else
                    {
                        ChangeTurn();

                    }
                }

            }

        }

        private bool CheckWinner(string symbol)
        {
            if (CheckHorizontal(symbol) || CheckVertical(symbol) || CheckDiagonal(symbol))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private bool CheckHorizontal(string playerSymbol)
        {
            if (b1.Text == $"{playerSymbol}" && b2.Text == $"{playerSymbol}"
                && b3.Text == $"{playerSymbol}")
            {
                if (horizontalMoves.Count > 0) { horizontalMoves.Clear(); }
                horizontalMoves.Add(b1);
                horizontalMoves.Add(b2);
                horizontalMoves.Add(b3);
                ChangeWinnerButtonColor(horizontalMoves);
                return true;
            }
            if (b4.Text == $"{playerSymbol}" && b5.Text == $"{playerSymbol}"
                && b6.Text == $"{playerSymbol}")
            {
                if (horizontalMoves.Count > 0) { horizontalMoves.Clear(); }
                horizontalMoves.Add(b4);
                horizontalMoves.Add(b5);
                horizontalMoves.Add(b6);
                ChangeWinnerButtonColor(horizontalMoves);
                return true;
            }
            if (b7.Text == $"{playerSymbol}" && b8.Text == $"{playerSymbol}"
              && b9.Text == $"{playerSymbol}")
            {
                if (horizontalMoves.Count > 0) { horizontalMoves.Clear(); }
                horizontalMoves.Add(b7);
                horizontalMoves.Add(b8);
                horizontalMoves.Add(b9);
                ChangeWinnerButtonColor(horizontalMoves);
                return true;
            }
            return false;
        }
        private bool CheckVertical(string playerSymbol)
        {
            if (b1.Text == $"{playerSymbol}" && b4.Text == $"{playerSymbol}"
                && b7.Text == $"{playerSymbol}")
            {
                if (verticalMoves.Count > 0) { verticalMoves.Clear(); }
                verticalMoves.Add(b1);
                verticalMoves.Add(b4);
                verticalMoves.Add(b7);
                ChangeWinnerButtonColor(verticalMoves);
                return true;
            }
            if (b2.Text == $"{playerSymbol}" && b5.Text == $"{playerSymbol}"
               && b8.Text == $"{playerSymbol}")
            {
                if (verticalMoves.Count > 0) { verticalMoves.Clear(); }
                verticalMoves.Add(b2);
                verticalMoves.Add(b5);
                verticalMoves.Add(b8);
                ChangeWinnerButtonColor(verticalMoves);
                return true;
            }
            if (b3.Text == $"{playerSymbol}" && b6.Text == $"{playerSymbol}"
           && b9.Text == $"{playerSymbol}")
            {
                if (verticalMoves.Count > 0) { verticalMoves.Clear(); }
                verticalMoves.Add(b3);
                verticalMoves.Add(b6);
                verticalMoves.Add(b9);
                ChangeWinnerButtonColor(verticalMoves);
                return true;
            }
            return false;

        }
        private bool CheckDiagonal(string playerSymbol)
        {
            if (b1.Text == $"{playerSymbol}" && b5.Text == $"{playerSymbol}"
                && b9.Text == $"{playerSymbol}")
            {
                if (diagonalMoves.Count > 0) { diagonalMoves.Clear(); }
                diagonalMoves.Add(b1);
                diagonalMoves.Add(b5);
                diagonalMoves.Add(b9);
                ChangeWinnerButtonColor(diagonalMoves);
                return true;
            }

            if (b3.Text == $"{playerSymbol}" && b5.Text == $"{playerSymbol}"
               && b7.Text == $"{playerSymbol}")
            {
                if (diagonalMoves.Count > 0) { diagonalMoves.Clear(); }
                diagonalMoves.Add(b3);
                diagonalMoves.Add(b5);
                diagonalMoves.Add(b7);
                ChangeWinnerButtonColor(diagonalMoves);
                return true;
            }
            return false;
        }

        private void ChangeWinnerButtonColor(List<Button> buttons)
        {
            if (buttons.Count > 0)
            {
                foreach (var item in buttons)
                {
                    item.Enabled = true;
                    item.ForeColor = Color.White;
                    item.BackColor = Color.LightGreen;

                }
            }
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            NewGame newGame = new NewGame();
            newGame.ShowDialog();
            CurrentPlayer.Text = firstPlayerName;
        }

        private void ResetBoard()
        {
            Rematch.Enabled = false;
            NewGame.Enabled = false;
            foreach (var item in allMoves)
            {
                item.Text = "";
                item.Enabled = true;
                item.BackColor = Control.DefaultBackColor;
                item.ForeColor = Control.DefaultForeColor;
            }
        }
        private void Rematch_Click(object sender, EventArgs e)
        {
            ResetBoard();
            CurrentPlayer.Text = firstPlayerName;
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            ResetBoard();
            NewGame form = new NewGame();
            form.ShowDialog();
            CurrentPlayer.Text = firstPlayerName;

        }
    }
}

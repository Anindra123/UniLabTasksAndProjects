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
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(firstPlayerName.Text.Trim()) && !String.IsNullOrEmpty(secondPlayerName.Text.Trim()))
            {
                TicTacToe.SetPlayerName(firstPlayerName.Text.Trim(), secondPlayerName.Text.Trim());
                this.Close();
            }
        }
    }
}

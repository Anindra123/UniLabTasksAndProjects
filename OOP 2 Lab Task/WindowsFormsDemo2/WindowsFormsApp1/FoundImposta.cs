using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class FoundImposta : Form
    {
        public FoundImposta()
        {

            InitializeComponent();
        }

        private void playAgainBtn_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Tag;
            form1.GenerateImposta();
            form1.Show();
            this.Close();
        }
    }
}

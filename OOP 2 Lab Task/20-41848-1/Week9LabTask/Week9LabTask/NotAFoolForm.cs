using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9LabTask
{
    public partial class NotAFoolForm : Form
    {
        public NotAFoolForm()
        {
            InitializeComponent();
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            var form = (Form1)Tag;
            this.Close();
            form.Show();
        }

        private void NotAFoolForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = (Form1)Tag;
            form.Show();
        }
    }
}

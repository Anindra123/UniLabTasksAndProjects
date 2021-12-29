using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10LabTask
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            var form = (Form1)Tag;
            form.Show();
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = Form1.name;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = (Form1)Tag;
            form.Show();

        }
    }
}

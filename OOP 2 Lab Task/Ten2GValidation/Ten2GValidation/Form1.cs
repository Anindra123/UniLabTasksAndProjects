using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ten2GValidation
{
    public partial class Form1 : Form
    {
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)==true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "field cannot  be empty");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBox2.Text.Trim(), pattern)==false)
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "invalid email");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "field cannot  be empty");
                MessageBox.Show("Wrong Input/s");
            }
            else if (Regex.IsMatch(textBox2.Text.Trim(), pattern) == false)
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "invalid email");
                MessageBox.Show("Wrong Input/s");
            }
            else
            {
                MessageBox.Show("welcome");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

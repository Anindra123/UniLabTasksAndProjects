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
using System.Data.SqlClient;

namespace Week10LabTask
{
    public partial class Form1 : Form
    {
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Fall 21-22\OOP 2 Lab Task\Week10LabTask\DB files\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30";
        public static string name;
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private bool CheckFields()
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordMTextBox.Text)
                )
            {
                return true;
            }
            return false;
        }
        private bool LoginUser(string name, string email, string pass)
        {
            dt.Clear();
            string query = $"select * from LOGIN_TBL where " +
                $" lower(name) = '{name}' and email = '{email}' and " +
                $"password = '{pass}'";

            using (SqlConnection sqlconn = new SqlConnection(connString))
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlconn);
                sda.Fill(dt);
            }
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.Focus();
                nameError.SetError(nameTextBox, "Name feild cannot be empty");
            }
            else
            {
                nameError.Clear();
            }
        }


        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                emailTextBox.Focus();
                emailError.SetError(emailTextBox, "Email feild cannot be empty");
            }

            else if (!Regex.IsMatch(emailTextBox.Text.Trim(), pattern))
            {
                emailTextBox.Focus();
                emailError.SetError(emailTextBox, "Invalid Email");
            }
            else
            {
                emailError.Clear();

            }
        }

        private void passwordMTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordMTextBox.Text))
            {
                passwordMTextBox.Focus();
                passwordError.SetError(passwordMTextBox, "Password feild cannot be empty");
            }
            else
            {
                passwordError.Clear();
            }
        }
        private void ClearFields()
        {
            emailTextBox.Text = null;
            passwordMTextBox.Text = null;
            nameTextBox.Text = null;
        }
        private void ValidateFeilds()
        {
            if (!CheckFields())
            {

                if (Regex.IsMatch(emailTextBox.Text.Trim(), pattern))
                {
                    //login
                    if (LoginUser(nameTextBox.Text.Trim().ToLower(),
                            emailTextBox.Text.Trim(),
                            passwordMTextBox.Text.Trim()))
                    {
                        ClearFields();
                        MessageBox.Show("Login Sucessful", "Sucess",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult dr = MessageBox.Show($"Welcome {dt.Rows[0]["NAME"].ToString()}",
                            "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            name = dt.Rows[0]["NAME"].ToString();
                            Dashboard db = new Dashboard();
                            db.Tag = this;
                            db.Show(this);
                            this.Hide();
                        }
                    }
                    else
                    {
                        ClearFields();
                        MessageBox.Show("Name/Email or password was invalid.Please try again.", "Couldn't Login",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Entered email was invalid", "Invalid Email",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Name, Email and password fields cannot be empty", "Empty feilds",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                ValidateFeilds();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            ValidateFeilds();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

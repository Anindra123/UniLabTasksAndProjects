using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // new

namespace TenGLoginDB
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        //update
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                Dashboard nextForm = new Dashboard();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=""E:\Fall 21-22\OOP 2 Lab Task\TenGLoginDB\TenGLoginDB\DB\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30");
            string query = "Select * from LOGIN_TBL where username = '" + txtUsername.Text.Trim() + "' and " +
                "pass = '" + txtPassword.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }

            else
            {
                MessageBox.Show("Username or Password incorrect");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

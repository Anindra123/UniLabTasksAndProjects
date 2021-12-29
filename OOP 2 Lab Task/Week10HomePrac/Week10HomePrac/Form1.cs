using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10HomePrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool verifyMemberSignIn(ProjectMember p)
        {
            if (p.Email != null && p.FirstName != null && p.LastName != null
                && p.password != null
                )
            {
                return true;
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            ProjectMember pMember = DBAcess.SignInProjectMember(
                textBox1.Text,
                textBox2.Text
                );
            if (verifyMemberSignIn(pMember))
            {
                MessageBox.Show("Login Sucessfull");
                MessageBox.Show($"Welcome {pMember.FirstName} " +
                    $"{pMember.LastName}");
            }
            else
            {
                MessageBox.Show("Email / Password Invalid");

            }
        }
    }
}

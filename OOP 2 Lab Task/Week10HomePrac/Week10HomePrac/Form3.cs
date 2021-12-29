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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DBAcess.SignUPProjectMember(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text))
            {
                MessageBox.Show("Sign up sucessful");
            }
            else
            {
                MessageBox.Show("Couldn't sign up");

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<ProjectGroup> groups = DBAcess.GetProjectGroups();
            if (groups.Count > 0)
            {
                comboBox1.DataSource = groups;
                comboBox1.DisplayMember = "PGroup_Name";
                comboBox1.ValueMember = "PGroup_ID";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = (int)comboBox1.SelectedValue;
            ProjectGroup group = DBAcess.GetGroup(id);
            if (group.PGroup_Name != null)
            {
                gname.Text = group.PGroup_Name;
            }
        }
    }
}
